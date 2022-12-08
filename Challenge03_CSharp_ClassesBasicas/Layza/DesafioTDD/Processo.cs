using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesafioTDD
{
    public class Processo
    {
        [Fact]
        public void ValorLiquidoIgual2000()
        {
            double esperado = 2000;
            double resultado = 0;

            Processo p = new Processo();
            p.ValorPedido = 5000;
            p.ValorGanho = 3000;

            resultado = p.ObterGanhoLiquido();
            Assert.Equal(esperado, resultado);
        }


        

    }
}
