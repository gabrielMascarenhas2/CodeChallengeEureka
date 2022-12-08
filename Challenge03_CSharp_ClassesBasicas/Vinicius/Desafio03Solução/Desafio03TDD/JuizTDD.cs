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
        public void temBoaExperiencia()
        {
            //Arrange
            bool esperado = true;
            bool resultado;

            Juiz J = new Juiz();
            J.AnosTrabalho = 15;

            //Assert
            resultado = J.temBoaExperiencia();
            Assert.Equal(esperado, resultado);
        }
    }

    public class JuizTDD2
    {
        [Fact]
        public void temBoaExperiencia()
        {
            //Arrange
            bool esperado = false;
            bool resultado;

            Juiz J = new Juiz();
            J.AnosTrabalho = 5;

            //Assert
            resultado = J.temBoaExperiencia();
            Assert.Equal(esperado, resultado);
        }

    }
}
