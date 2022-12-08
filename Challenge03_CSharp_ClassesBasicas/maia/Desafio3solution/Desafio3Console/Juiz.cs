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
        public int AnosdeTrabalho { get; set; }


        public bool TemBoaExperiencia()
        {
            if(AnosdeTrabalho >=10)
            {
              return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
