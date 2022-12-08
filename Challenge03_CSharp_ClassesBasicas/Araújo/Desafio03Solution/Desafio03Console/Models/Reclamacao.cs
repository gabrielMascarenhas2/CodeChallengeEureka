using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Console
{
    public class Reclamacao
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int NumeroDeDiasPassado { get; set; }

        public string ReclamacaoAtual()
        {
            if (NumeroDeDiasPassado > 30)
            {
                return "Reclamação está Atrasada";
            }
            else
            {
                return "Reclamação está Válida";
            }
        }
    }
}
