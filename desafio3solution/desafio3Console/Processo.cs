using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3Console
{
   public class Processo
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public double Valorpedido { get; set; } 
        public double Valorganho { get; set; }

        public int obterganholiquido ()
        {
            return 0; 
        }

    }
}
