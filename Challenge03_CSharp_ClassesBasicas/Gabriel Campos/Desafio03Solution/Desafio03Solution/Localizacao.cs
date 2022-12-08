using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Console
{
    class Localizacao
    {
        public int ID { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string rua { get; set; }


        public string enderecoCompleto()
        {
            return cidade + estado + rua;


        }



    }
}
