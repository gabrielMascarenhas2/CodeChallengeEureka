using Desafio03Console;
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

            Juiz J = new Juiz();
            J.AnosTrabalho = 10;

            //Assert
            resultado = J.TemBoaexperiencia();
            Assert.Equal(esperado, resultado);

        }
    }
}
