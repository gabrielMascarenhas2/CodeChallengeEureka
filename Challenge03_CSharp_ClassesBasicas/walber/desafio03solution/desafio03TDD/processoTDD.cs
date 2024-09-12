using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace desafio03TDD
{
    public class processoTDD
    {
        [Fact]
        public void ValorLiquidoIual1000()
        {
            //Arrange 
            double esperado = 2000;
            double resultado = -0;

            Processor p = new Processor();
            p.ValorPedido = 5000;
            p.Valorganho = 3000;


            //Assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);
        }

    }
}
