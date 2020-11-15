using BioparkCommunication.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioparkCommunication.Visao;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;

namespace BioparkCommunication.Controle
{
    public class BancoDeDados
    {
        SqlConnectionStringBuilder sqlConnectionStringBuilder;
        SqlConnection conexaoBaseDeDados;
        public Colaborador usuarioLogado;

        public BancoDeDados()
        {
            sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
            sqlConnectionStringBuilder.DataSource = "tcp:biopark.database.windows.net,1433";
            sqlConnectionStringBuilder.UserID = "Administrador";
            sqlConnectionStringBuilder.Password = "Adm.123456";
            sqlConnectionStringBuilder.InitialCatalog = "bioparkcommunication";
            conexaoBaseDeDados = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

        }

        public void retornarSelect(ListView listViewASerPreenchida)
        {
            String query = "Select agend.ID_Agendamento as [Numero do Agendamento],colab.Usuario as Solicitante, colab.Usuario as Concedente, stts.Situacao as Situacao,"
                           + "frm.Tipo, agend.DataPedido as [Data da Solicitacao], agend.DataAgendada as [Data Agendada], agend.Identificador as Identificador,"
                           + "agend.Titulo, agend.Mensagem"
                           + " From tb_agendamento agend"
                           + " inner join tb_colaborador colab"
                           + " on colab.ID_Colaborador = agend.ID_Colaborador_Solicitante"
                           + " inner join tb_formaenvio frm"
                           + " on agend.ID_FormaEnvio = frm.ID_FormaEnvio"
                           + " inner join tb_status stts"
                           + " on stts.ID_Status = agend.ID_Status"
                           + @" where agend.ID_Colaborador_Solicitante = @idColaborador";
            try
            {
                
                conexaoBaseDeDados.Open();
                SqlCommand querySql = new SqlCommand(query, conexaoBaseDeDados);
                querySql.Parameters.Add("@idColaborador", SqlDbType.Int).Value = usuarioLogado.IdColaborador;
                SqlDataReader retorno = querySql.ExecuteReader();
                if (retorno.HasRows)
                {
                    String[] linha = new String[10];


                    while (retorno.Read())
                    {
                        linha[0] = retorno.GetInt32(0).ToString();
                        linha[1] = retorno.GetString(1);
                        linha[2] = retorno.GetString(2);
                        linha[3] = retorno.GetString(3);
                        linha[4] = retorno.GetString(4);
                        linha[5] = retorno.GetDateTime(5).ToString();
                        linha[6] = retorno.GetDateTime(6).ToString();
                        linha[7] = retorno.GetString(7);
                        linha[8] = retorno.GetString(8);
                        linha[9] = retorno.GetString(9);

                        
                        ListViewItem listViewItem = new ListViewItem(linha);
                        listViewASerPreenchida.Items.Add(listViewItem);
                    }
                    
                }
                
                

            }
            catch (Exception e)
            {
                MessageBox.Show("error:  " + e.Message);
               
            }
            finally
            {
                conexaoBaseDeDados.Close();
            }
        }


        private void criarLinha(String numeroAgendamento, String solicitante, String concedente, String situacao, String tipo, String dataPedido, String dataAgendada, String identificador)
        {

        }




        public void registrar(Colaborador usuarioARegistrar)
        {                   
            String query = @"INSERT INTO tb_colaborador(Usuario,Senha,Funcao) VALUES(@usuario,@senha,@funcao)";

            try
            {
                conexaoBaseDeDados.Open();

                SqlCommand querySql = new SqlCommand(query, conexaoBaseDeDados);

                querySql.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuarioARegistrar.Usuario;
                querySql.Parameters.Add("@senha", SqlDbType.VarChar).Value = usuarioARegistrar.Senha;
                querySql.Parameters.Add("@funcao", SqlDbType.Int).Value = usuarioARegistrar.Funcao;

                querySql.ExecuteNonQuery();
               
                
             

            }
            catch (Exception e)
            {
                MessageBox.Show("error:  " + e.Message);
            }
            finally
            {
                conexaoBaseDeDados.Close();
            }

            
        }

        public void entrar(Colaborador usuarioALogar, FRMTelaDeLogin frmTelaDeLogin)
        {
            String query = @"Select * from tb_colaborador where Usuario = @Usuario and Senha = @Senha";
            SqlCommand querySql = new SqlCommand(query, conexaoBaseDeDados);
            querySql.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuarioALogar.Usuario;
            querySql.Parameters.Add("@Senha", SqlDbType.VarChar).Value = usuarioALogar.Senha;

            querySql.CommandTimeout = 60;
            try
            {
                conexaoBaseDeDados.Open();
                
                SqlDataReader retorno = querySql.ExecuteReader();
                if (retorno.HasRows)
                {
                   
                    retorno.Read();
                    if (usuarioALogar.Usuario.Equals(retorno.GetString(1)) && usuarioALogar.Senha.Equals(retorno.GetString(2)))
                    {
                        usuarioALogar.IdColaborador = retorno.GetInt32(0);
                        usuarioALogar.Funcao = retorno.GetInt32(3);
                        usuarioLogado = usuarioALogar;
                        
                        switch (usuarioALogar.Funcao)
                        {
                            case 0: //solicitante
                                FRMVisaoSolicitante frmVisaoSolicitante = new FRMVisaoSolicitante(frmTelaDeLogin,this);
                                frmVisaoSolicitante.Show();
                                

                                break;                               
                            case 1: //autorizador
                                FRMVisaoAutorizador frmVisaoAutorizador = new FRMVisaoAutorizador();                                
                                frmVisaoAutorizador.Show();
                                

                                break;
                            default: //erro
                                MessageBox.Show("Erro: Colaborador com função diferente do sistema");
                                break;

                        }                       
                    }
                }
                else
                {
                    MessageBox.Show("Não teve retorno");
                }
                
                
            }
            catch (Exception e)
            {
                MessageBox.Show("error: " + e.Message);
            }
            finally
            {
                conexaoBaseDeDados.Close();
            }
        }

        public void solicitarAgendamento(Agendamento solicitacaoAgendamento)
        {
            String query = @"INSERT INTO tb_agendamento(ID_Colaborador_Solicitante,ID_FormaEnvio,DataPedido,DataAgendada,Identificador,Titulo,Mensagem) "
                         + @"VALUES(@idColaborador, @idFormaEnvio, getDate(), @dataAgendada, @identificador, @titulo, @mensagem); ";
            solicitacaoAgendamento.ColaboradorSolicitante = usuarioLogado;
            SqlCommand querySql = new SqlCommand(query, conexaoBaseDeDados);
            querySql.CommandTimeout = 60;

            try
            {
                conexaoBaseDeDados.Open();

                querySql.Parameters.Add("@idColaborador", SqlDbType.Int).Value = solicitacaoAgendamento.ColaboradorSolicitante.IdColaborador;
                querySql.Parameters.Add("@idFormaEnvio", SqlDbType.Int).Value = solicitacaoAgendamento.IdFormaEnvio;
                querySql.Parameters.Add("@dataAgendada", SqlDbType.DateTime).Value = solicitacaoAgendamento.DataAgendada.ToString("o", CultureInfo.CreateSpecificCulture("en-Us"));
                querySql.Parameters.Add("@identificador", SqlDbType.VarChar).Value = solicitacaoAgendamento.Identificador;
                querySql.Parameters.Add("@titulo", SqlDbType.VarChar).Value = solicitacaoAgendamento.Titulo;
                querySql.Parameters.Add("@mensagem", SqlDbType.VarChar).Value = solicitacaoAgendamento.Mensagem;

                querySql.ExecuteNonQuery();
                MessageBox.Show("Registrado com sucesso");
            }

            catch (Exception e)
            {
                MessageBox.Show("error: " + e.Message);
            }
            finally
            {
                conexaoBaseDeDados.Close();
            }
        }
    }
}
