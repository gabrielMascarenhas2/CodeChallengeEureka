using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    public class Localizacao
    {
        public int ID { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }

        public string enderecoCompleto()
        {
            return Cidade+Estado+Rua;
        }
    }
}
