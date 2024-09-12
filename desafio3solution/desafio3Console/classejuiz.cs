using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3Console
{
    public class classejuiz
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int anosdeTrabalho { get; set; }

        public bool temBoaExperiencia()
        {
            if (anosdeTrabalho > 10)
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
