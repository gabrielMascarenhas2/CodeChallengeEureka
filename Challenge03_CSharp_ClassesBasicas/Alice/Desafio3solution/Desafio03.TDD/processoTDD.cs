using Desafio3console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03.TDD
{
    public class processoTDD
    {
        [Fact]
        public void ValorLiquidoigual2000()
        {
            // Arrange 
            double esperado = 2000;
            double resultado = -1;

            processo p = new processo();
            p.valorpedido = 5000;
            p.valorganho = 3000;

            //Assert
            resultado = p.obterGanhoLiquido(); 
            Assert.Equal(esperado, resultado);


        }

        
    }
}
