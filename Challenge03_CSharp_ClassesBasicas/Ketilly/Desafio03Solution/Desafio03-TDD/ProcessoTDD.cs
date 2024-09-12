using Desafio03console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Desafio03_TDD
{
    public class ProcessoTDD
    {
         [Fact]
        public void ValorliquidoIgual2000()
        {
            //Arrange
            double esperando = 2000;
            double resultado = 0;

            
            Processo p = new Processo();
            p.ValorPedido = 5000;
            p.ValorGanho = 3000;

            //Assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperando, resultado);
        }
    }
}
