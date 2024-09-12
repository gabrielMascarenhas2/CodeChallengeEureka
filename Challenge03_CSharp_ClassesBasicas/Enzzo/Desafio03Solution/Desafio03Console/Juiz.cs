using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03Console
{
    public class Juiz
    {


        public int Id { get; set; }
        public string nome { get; set; }
        public int anostrabalho { get; set; }




       public string temBoaExperiencia()
        {

            if  (anostrabalho > 10)
            {

                return "tem experiencia";

            }
            else
            {

                return "pouca experiencia";
            }

                

           

        }




    }
}
