using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioparkCommunication.Modelo;

namespace BioparkCommunication.Visao
{
    public partial class FRMConsulta : Form
    {
        Agendamento agendamentoSelecionado;
        public FRMConsulta(Agendamento agendamentoSelecionado)
        {
            InitializeComponent();
            this.agendamentoSelecionado = agendamentoSelecionado;
        }

        private void FRMConsulta_Load(object sender, EventArgs e)
        {
            TXTBNumeroAgendamento.Text = agendamentoSelecionado.IdAgendamento.ToString();
            TXTBSolicitante.Text = agendamentoSelecionado.ColaboradorSolicitante.Usuario;
            
               

        }
    }
}
