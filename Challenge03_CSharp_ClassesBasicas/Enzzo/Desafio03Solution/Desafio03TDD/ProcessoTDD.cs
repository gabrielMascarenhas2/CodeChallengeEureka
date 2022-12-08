using Desafio03Console;
using System;
using Xunit;

namespace Desafio03TDD
{
    public class ProcessoTDD
    {
        [Fact]
        public void ValorLiquidoIgual2000()
        {

            

            Processo p = new Processo();
           
            double esperado = 6000;

            p.Valorpedido = 7000;
            p.Valorganho = 1000;
            double resultado = p.Valorpedido - p.Valorganho;
            resultado = p.obterganholiquido();
            Assert.Equal(esperado, resultado);




        }
    }
}
