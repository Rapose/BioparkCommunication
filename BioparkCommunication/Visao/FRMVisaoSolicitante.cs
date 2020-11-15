using BioparkCommunication.Controle;
using System;
using System.Windows.Forms;

namespace BioparkCommunication.Visao
{
    
    public partial class FRMVisaoSolicitante : Form
    {
        FRMTelaDeLogin telaPrincipal;
        BancoDeDados bancoDeDados;
        public FRMVisaoSolicitante(FRMTelaDeLogin frmTelaDeLogin, BancoDeDados bancoDeDados)
        {
            InitializeComponent();
            telaPrincipal = frmTelaDeLogin;
            this.bancoDeDados = bancoDeDados;
        }

        private void TSMIEmail_Click(object sender, EventArgs e)
        {
            FRMSolicitarEmail frmSolicitarEmail = new FRMSolicitarEmail(bancoDeDados);
            carregarFormPainel(frmSolicitarEmail);
        }

        private void TSMIPush_Click(object sender, EventArgs e)
        {
            FRMSolicitarPush frmSolicitarPush = new FRMSolicitarPush();
            carregarFormPainel(frmSolicitarPush);
        }

        private void TSMISms_Click(object sender, EventArgs e)
        {
            FRMSolicitarSms frmSolicitarSms = new FRMSolicitarSms();
            carregarFormPainel(frmSolicitarSms);
        }

        private void TSMIWhatsapp_Click(object sender, EventArgs e)
        {
            FRMSolicitarWhatsapp frmSolicitarWhatsapp = new FRMSolicitarWhatsapp();
            carregarFormPainel(frmSolicitarWhatsapp);
        }

        private void carregarFormPainel(Form formASerCarregado)
        {
            PNLPrincipal.Controls.Clear();
            formASerCarregado.TopLevel = false;
            PNLPrincipal.Controls.Add(formASerCarregado);
            formASerCarregado.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formASerCarregado.Dock = DockStyle.Fill;
            formASerCarregado.Show();
        }

        private void FRMVisaoSolicitante_Load(object sender, EventArgs e)
        {
            telaPrincipal.Hide();

        }

        private void FRMVisaoSolicitante_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaPrincipal.Show();
        }

      
    }
}
