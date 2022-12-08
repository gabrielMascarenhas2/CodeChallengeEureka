using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Console
{
    public class Processoo
    {

        public int ID { get; set; }
        public string Descricao { get; set; }
        public string Motivo { get; set; }
        public string Status { get; set; }
        public double valorPedido { get; set; }
        public double valorGanho { get; set; }

        public double obterGanhoLiquido()
        {
            return valorPedido - valorGanho;
        }

    }
}
