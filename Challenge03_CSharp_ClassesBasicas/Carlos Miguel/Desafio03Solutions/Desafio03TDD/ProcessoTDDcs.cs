using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class ProcessoTDDcs
    {
        [Fact]
        public void ValorLiquidoIgual2000()
        {
            //Arrange
            double esperado = 2000;
            double resultado = 0;

            Processo p = new Processo();
            p.valorPedido = 5000;
            p.valorGanho = 3000;

            //Assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);
        }
    }
}
