using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    public class Reclamacao
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int numeroDeDiasPassado { get; set; }

        public string situacaoReclamacao()
        {
            if (numeroDeDiasPassado > 30)
            {
                return "Reclamacão atrasada.";
            }
            else
            {
                return "Reclamação não está atrasada.";
            }
        }
    }
}
