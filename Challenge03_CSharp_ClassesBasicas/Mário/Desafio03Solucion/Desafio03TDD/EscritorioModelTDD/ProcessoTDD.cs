using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class ProcessoTDD
    {
        [Fact]
        public void ValorLiquidoIgual2000()
        {
            //Arrange
            double esperado = 2000;

            Processo p = new Processo();
            p.valorPerdido = 5000;
            p.valorGanho = 3000;

            //assert
            double resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);
        }
    }
}
