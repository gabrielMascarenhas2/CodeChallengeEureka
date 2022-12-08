using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3Console
{
    public class Reclamação
    {

        public int ID { get; set; }
        public string Descricao { get; set; }
        public int NumeroDeDiasPassado { get; set; }

        public bool situacaoReclamacao() 
        {

            if (NumeroDeDiasPassado >= 30)
            {
                Console.WriteLine("A Reclamação Esta Atrasada");
                return true;

            }
            else
            {
                Console.WriteLine("A Reclamação Não Esta Atrasada");
               return false;


            }
        
        
        }



    }
}
