using Desafio03console;
using System;
using Xunit;

namespace TestProject1
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

            //assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);

        }
    }      
}
