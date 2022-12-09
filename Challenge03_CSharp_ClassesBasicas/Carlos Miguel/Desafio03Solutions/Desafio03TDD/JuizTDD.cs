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
        public void temBoaExperienciaIgualTrue()
        {
            //Arrange
            bool esperado = true;
            bool resultado;

            Juiz j = new Juiz();
            j.AnosTrabalho = 11;

            //Assert
            resultado = j.temBoaExperiencia();
            Assert.Equal(esperado, resultado);
        }
    }
}
