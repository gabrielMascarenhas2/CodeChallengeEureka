using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03TDD
{
    public class processoTDD
    {
        [Fact]
        public void valorLiquidoIgual1000()
        {
            //Arranje
            double esperando = 200;
            double resultado = -1;

            Processo p = new Processo();
            p.valorepedido = 500;
            p.valorGanho = 3000;


            //assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);
    }
}
