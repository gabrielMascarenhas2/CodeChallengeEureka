using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_3
{
    public class Classe_reclamacao_cs
    {
        public int ID { get; set; }
        public string Descrição { get; set; }
        public int NumeroDeDiasPassado { get; set; }

        public string SituaçãoReclamação()
        {
            if (NumeroDeDiasPassado > 30)
            {
                return "atrasado";
            }
            {
                return "Não atrasado";
            }
        }
    }
}
