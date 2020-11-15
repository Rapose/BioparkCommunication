using BioparkCommunication.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioparkCommunication.Controle;

namespace BioparkCommunication.Visao
{
    public partial class FRMSolicitarEmail : Form
    {
        BancoDeDados bancoDeDados;
        LVPainel lvPainel;
        
        public FRMSolicitarEmail(BancoDeDados bancoDeDados)
        {
            InitializeComponent();
            this.bancoDeDados = bancoDeDados;


            


        }

        private void BTNSolicitarAgendamento_Click(object sender, EventArgs e)
        {
          
            Agendamento agendamento = new Agendamento();
            String[] data = DTPDataParaEnvioData.Text.Split('/');
            String[] hora = DTPDataParaEnvioHora.Text.Split(':');
            
            agendamento.IdFormaEnvio = 1;
            DateTime dataAgendada = new DateTime(int.Parse(data[2]), int.Parse(data[1]), int.Parse(data[0]), int.Parse(hora[0]), int.Parse(hora[1]),00);
            
            
            agendamento.Identificador = TXTBDestinatario.Text;
            agendamento.Titulo = TXTBAssunto.Text;
            agendamento.Mensagem = TXTBMensagem.Text;


            
            agendamento.DataAgendada = dataAgendada;
            bancoDeDados.solicitarAgendamento(agendamento);
            bancoDeDados.retornarSelect(lvPainel.painelASerPreenchido);

        }

        private void FRMSolicitarEmail_Load(object sender, EventArgs e)
        {
            DTPDataParaEnvioHora.Format = DateTimePickerFormat.Custom;
            DTPDataParaEnvioHora.CustomFormat = "HH:mm";
            lvPainel = new LVPainel(LVConsulta,bancoDeDados);
            lvPainel.painelASerPreenchido.View = View.Details;
            lvPainel.painelASerPreenchido.FullRowSelect = true;
            bancoDeDados.retornarSelect(lvPainel.painelASerPreenchido);
        }

        private void LVConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LVConsulta_DoubleClick(object sender, EventArgs e)
        {
            
            
        }
    }
}
