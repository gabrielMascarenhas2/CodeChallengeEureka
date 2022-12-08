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
            double resultado;

            Processoo p = new Processoo();
            p.valorPedido = 5000;
            p.valorGanho = 3000;

            //Assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);
        }

    }
}
