using Desafio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio3TDD
{
    public class ProcessoTDD
    {
        [Fact]
        public void ValorLiquidoIgual2000()
        {
            //Arrange
            double esperado = 2000;
            double resultado = 0;

            Processo p = new Processo();
            p.ValorPedido = 5000;
            p.ValorGanho = 3000;


            //Assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);

        }
    }
}
