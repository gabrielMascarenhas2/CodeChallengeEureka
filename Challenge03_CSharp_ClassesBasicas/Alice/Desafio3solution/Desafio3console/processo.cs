using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3console
{
    public class processo
    {
        public int ID { get; set; }
        public string descrição{ get; set; }
        public string motivo { get; set; }
        public string status { get; set; }
        public double valorpedido { get; set; }
        public double valorganho { get; set; } 


        public int obterGanhoLiquido()
        {
            return 0;
        }


    }
}
