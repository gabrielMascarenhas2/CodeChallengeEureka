using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Desafio03Console;
using Desafio03Console.EscritorioModel;

namespace Desafio03TDD.EscritorioModelTDD
{
    public class JuizTDD
    {
        [Fact]
        public void boaExperiencia()
        {
            //Arrange
            bool esperado = true;

            Juiz juiz = new Juiz();
            juiz.AnosTrabalho = 11;
            bool resultado = juiz.temBoaExperiencia();

            //Assert
            Assert.Equal(esperado, resultado);
        }

    }
}
