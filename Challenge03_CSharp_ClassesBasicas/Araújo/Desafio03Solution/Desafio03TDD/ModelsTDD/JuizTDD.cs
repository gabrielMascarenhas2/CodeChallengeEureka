using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD.ModelsTDD
{
    public class JuizTDD
    {
        [Fact]
        public void TemBoaExperiencia()
        {
            //Arrange
            bool esperado = true;
            bool resultado;

            Juiz j = new Juiz();
            j.AnosDeTrabalho = 20;

            //Assert 
            resultado = j.TemBoaExperiencia();
            Assert.Equal(esperado, resultado);
        }
    }
}
