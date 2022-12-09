using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_3
{
    public class Juiz
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int AnosDeTrabalho { get; set; }

        public bool TemBoaExperiencia()
        {
            if (AnosDeTrabalho >= 10)
            {

                return true;

            }
            {
                return false;
            }
              
        }
    }
}
