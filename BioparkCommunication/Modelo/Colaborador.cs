using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioparkCommunication.Modelo
{
    public class Colaborador
    {
        private int idColaborador;
        private String usuario;
        private String senha;
        private int    funcao; //0 -> solicitante / 1 -> Autorizador

        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Funcao { get => funcao; set => funcao = value; }
        public int IdColaborador { get => idColaborador; set => idColaborador = value; }
    }
}
