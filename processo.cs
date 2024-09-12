using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio03console
{
    public class processo
    {

        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public double ValorPedido { get; set; }
        public double ValorGanho { get; set; }

        public int obterGanhoLiquido()
        {
            return 0;
        }
                


    }
}
