using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesafioTDD
{
   
   public class JuizTDD
   {
        [Fact]
        public void obtertempoExperiencia()
        {
            //Arrange
            bool resultado = false;
            bool esperado = true;
             Juiz J = new Juiz();
             J.ID = 1;
            J.AnosTrabalho = 5;
            J.Nome = null;

            //Assert
            resultado = J.obtertempoExperiencia();
            Assert.Equal(esperado, resultado);

        }
         
   }
}
