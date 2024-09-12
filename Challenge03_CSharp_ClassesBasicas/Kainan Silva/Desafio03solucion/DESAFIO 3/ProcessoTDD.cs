using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_3
{
    public class ProcessoTDD
    {
        [Fact]
        public void ValorLiquidoIgual1000()
        {
            //Arrange 
            double esperado = 2000;
            double resultado = -1;

            Processo p = new Processo();
            p.ValorPedido = 5000;
            p.valorGanho = 3000;


            //Assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);
        }
    }
}
