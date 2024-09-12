using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3Console
{
   public  class reclamacao
    {
        public int ID { get; set; }
        public string descricao { get; set; }
        public int numeroDeDiasPassados { get; set; }

        public string Reclamacao()
        {
            if (numeroDeDiasPassados > 30)
            {
                return "A reclamação está atrasada";

            }
            else
            {
                return "A reclamação está valida ";
            }






        }

    }
}
