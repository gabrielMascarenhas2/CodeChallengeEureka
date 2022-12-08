using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03.TDD
{
    public class juiz
    {
        private int anosTrabalho;
        private int anosTrabalhoPedido;

        public static object TemBoaExperiencia { get; private set; }

        [Fact]
        public void TempoDeExperiencia9anos()
        {
            // Arrange 
            double esperado = 9;
            double resultado = -1;

            juiz j = new juiz();
            j.anosTrabalho = 8;
            j.anosTrabalhoPedido = 10;

            //Assert
            resultado = j.TemBoaExperiencia();
            Assert.Equal(esperado, resultado);


        }

        

       
    }
}
