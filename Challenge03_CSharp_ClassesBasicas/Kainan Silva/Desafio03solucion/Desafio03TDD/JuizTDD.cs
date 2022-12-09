using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class JuizTDD
    {
        [Fact]
        public void TemBoaexperiencia() 
        {
            //Arrange 
            bool esperado = true;
            bool resultado;

            JuizTDD j = new JuizTDD();

            j.AnosDeTrabalho = 10 ;

            //Assert
            resultado = j.TemBoaexperiencia();
                Assert.Equal(esperado, resultado);
           

        }
        


            
    }
}
