using BioparkCommunication.Controle;
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

namespace BioparkCommunication.Visao
{
    public partial class FRMRegistrar : Form
    {
        
        public FRMRegistrar()
        {
            InitializeComponent();
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            Colaborador colaborador = new Colaborador();
            colaborador.Usuario = TXTBUsuario.Text;
            colaborador.Senha = TXTBSenha.Text;
            if (RDOBAutorizador.Checked)
            {
                colaborador.Funcao = 1;
            }
            else
            {
                colaborador.Funcao = 0;
            }


            
                bancoDeDados.registrar(colaborador);
            
             
        }
    }
}
