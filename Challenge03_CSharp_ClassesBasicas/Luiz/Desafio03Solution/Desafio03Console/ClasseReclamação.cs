using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Console
{
    public class ClasseReclamação
    {
        public int ID { get; set; }
        public string Descrição { get; set; }
        public int numeroDeDiasPassado { get; set; }

         public string situacaoReclamacao()
        {

            return Descrição;
        }
    }
}
