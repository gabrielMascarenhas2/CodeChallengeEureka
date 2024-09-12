using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03console
{
    public class JUIZ
    {
        public int ID { get; set; }
        public int Nome { get; set; }
        public int AnosTrabalho { get; set; }

        public bool tempoExperiencia()
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
