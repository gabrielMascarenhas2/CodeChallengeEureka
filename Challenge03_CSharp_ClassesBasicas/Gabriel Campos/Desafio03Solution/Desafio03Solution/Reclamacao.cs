using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Console
{
    class Reclamacao
    {
        public int ID { get; set; }
        public string Descicao { get; set; }
        public int numeroDeDiasPassado { get; set; }
         
        public string SituacaoReclamacao()
        {
            if(numeroDeDiasPassado > 30)
            {
                return "Está atrasado";
            }
            else
            {
                return "Está dentro do prazo";

            }


        }





    }
}
