using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3console
{
    class juiz
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public string AnosTrabalho { get; set; }

        public bool temBoaExperiencia()
        {
            if (AnosTrabalho > 10) 
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
