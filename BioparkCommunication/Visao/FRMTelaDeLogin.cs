using BioparkCommunication.Controle;
using BioparkCommunication.Modelo;
using BioparkCommunication.Visao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ubiety.Dns.Core.Records.NotUsed;

namespace BioparkCommunication
{
    public partial class FRMTelaDeLogin : Form
    {
        public FRMTelaDeLogin()
        {
            InitializeComponent();
        }

        private void BTNEntrar_Click(object sender, EventArgs e)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            Colaborador logando = new Colaborador();
            logando.Usuario = TXTBUsuario.Text;
            logando.Senha = TXTBSenha.Text;

            bancoDeDados.entrar(logando, this);
           
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            FRMRegistrar frmRegistrar = new FRMRegistrar();
            frmRegistrar.Show();
          
        }

        private void FRMTelaDeLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
