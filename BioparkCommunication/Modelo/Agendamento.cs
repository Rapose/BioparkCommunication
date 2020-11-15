using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioparkCommunication.Modelo
{
    public class Agendamento
    {
        private int idAgendamento;
        private Colaborador colaboradorSolicitante;
        private Colaborador colaboradorAutorizador;
        private int idStatus;   // 1-Aguardando Aprovação / 2-Agendado / 3-Enviado / 4-Recusado / 5-Erro
        private int idFormaEnvio; // 1-Email / 2-Push / 3-Sms / 4-Whatsapp
        private DateTime dataPedido;
        private DateTime dataAgendada;
        private String identificador;
        private String titulo;
        private String mensagem;

        public int IdAgendamento { get => idAgendamento; set => idAgendamento = value; }
        public int IdStatus { get => idStatus; set => idStatus = value; }
        public int IdFormaEnvio { get => idFormaEnvio; set => idFormaEnvio = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Mensagem { get => mensagem; set => mensagem = value; }
        public DateTime DataPedido { get => dataPedido; set => dataPedido = value; }
        public DateTime DataAgendada { get => dataAgendada; set => dataAgendada = value; }
        internal Colaborador ColaboradorSolicitante { get => colaboradorSolicitante; set => colaboradorSolicitante = value; }
        internal Colaborador ColaboradorAutorizador { get => colaboradorAutorizador; set => colaboradorAutorizador = value; }
    }
}
