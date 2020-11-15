using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioparkCommunication.Modelo;

namespace BioparkCommunication.Controle
{
    public class LVPainel
    {
        public ListView painelASerPreenchido;
        BancoDeDados bancoDeDados;
        public LVPainel(ListView painelASerPreenchido, BancoDeDados bancoDeDados)
        {
            this.painelASerPreenchido = painelASerPreenchido;
            
            painelASerPreenchido.Columns.Add("Número do Agendamento",100);
            painelASerPreenchido.Columns.Add("Solicitante", 100);
            painelASerPreenchido.Columns.Add("Concedente", 100);
            painelASerPreenchido.Columns.Add("Status", 100);
            painelASerPreenchido.Columns.Add("Forma de Envio", 100);
            painelASerPreenchido.Columns.Add("Data de Solicitação", 100);
            painelASerPreenchido.Columns.Add("Data de Agendamento", 100);
            painelASerPreenchido.Columns.Add("Identificador", 100);
            painelASerPreenchido.Columns.Add("Titulo", 100);
            painelASerPreenchido.Columns.Add("Mensagem", 100);
            



            this.bancoDeDados = bancoDeDados;
        }

        public void popularListView()
        {

        }


    }
}
