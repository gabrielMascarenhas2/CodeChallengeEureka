using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Console
{
    public class Juiz
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int AnosDeTrabalho { get; set; }

        public bool TemBoaExperiencia()
        {
            if (AnosDeTrabalho > 10)
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
