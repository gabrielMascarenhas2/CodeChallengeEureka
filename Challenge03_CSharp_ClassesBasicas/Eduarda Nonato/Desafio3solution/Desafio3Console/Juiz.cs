﻿using System;
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
        public int AnosTrabalho { get; set; }

        public bool obtertempoExperiencia()
        {
            if (AnosTrabalho>10)
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