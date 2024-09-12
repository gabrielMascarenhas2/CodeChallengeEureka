using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3Console
{
    public class Reclamacao
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int numeroDeDiasPassado { get; set; }


        public string SituacaoReclamacao()
        {
            if (numeroDeDiasPassado > 30)
            {
                return "A reclamação esta atrasada";
            }
            else
            {
                return "A reclamação não esta atrasada"; 
            }
        }
    }
}
