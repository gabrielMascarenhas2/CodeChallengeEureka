using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_3
{
    public class Processo
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string  Motivo { get; set; }
        public string  Status { get; set; }      
        public double ValorPedido { get; set; }
        public double valorGanho { get; set; }

        public double obterGanhoLiquido()
        {
            return int  (ValorPedido, valorGanho);

        }
    }
}
