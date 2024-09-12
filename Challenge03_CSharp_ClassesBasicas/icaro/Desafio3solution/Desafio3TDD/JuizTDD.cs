using Desafio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio3TDD
{
    public class JuizTDD
    {
        [Fact]
        public void BoaExperienciaExample()
        {
            //Arrange
            bool esperado = true;
            bool resultado = false;

            Juiz Y = new Juiz();
            Y.AnosTrabalho = 22;

            //Assert
            resultado = Y.temBoaExperiencia();
            Assert.Equal(esperado, resultado);
        }

        
    }
}
