﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3console
{
    class Reclamacao
    {
        

        public int ID { get; set; }
        public string descrição { get; set; }
        public int numeroDeDiasPassado { get; set; }
        public string situacaoReclamacao()
        {
            if (numeroDeDiasPassado > 30)
            {
                return "atrasado";
            }
            else
            {
                return "nao atrasado"; 
            }




        }
       
           
           
    }


}
}
