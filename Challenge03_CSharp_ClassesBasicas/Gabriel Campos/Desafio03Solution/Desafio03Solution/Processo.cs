using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Solution
{

    public class Processo
    {
        public int ID { get; set; }
        public string Descicao { get; set; }
        public string Motivo { get; set; }
        public string status { get; set; }
        public double Valorpedido { get; set; }
        public int Valorganho { get; set; }



        public double obterganholiquido()
        {

            return Valorganho - Valorpedido;
        }





    }
    
}
