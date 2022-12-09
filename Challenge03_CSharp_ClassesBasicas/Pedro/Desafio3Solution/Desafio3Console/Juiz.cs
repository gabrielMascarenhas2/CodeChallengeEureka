using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3Console
{
    public class Juiz
    {

        public int ID { get; set; }
        public string Nome { get; set; }
        public int AnosTrabalho { get; set; }

        public bool temBoaExperiencia() 
        {

            if (AnosTrabalho >= 10)
            {
                Console.WriteLine("Tem Boa Experiencia");
                return true;

            }
            else
            {
                Console.WriteLine("Não Tem Experiencia Minima");
                 return false;
            }
        
        
        }


    }
}
