using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace desafio03TDD
{
   public class juizTDD
    {
        [Fact]
        public void boaExperiencia()
        {
            //Arrange
            bool esperado = true;

            juizTDD juiz = new juizTDD();
            juiz.Anostrabalho = 11;
            bool resultado = juiz.temboarxperiencia();

            //assert
            Assert.Equal(esperado, resultado);
        }
    }
}
