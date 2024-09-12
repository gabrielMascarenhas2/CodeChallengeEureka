using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03TDD
{
    public class ProcessoTDD
    {
        [Fact]
        public void ValorLiquidoIgual1000()
        {
            //Arranje
            double esperado = 2000;
            double resultado = 0;

            Processo p = new Processo();
            p.ValorPedido = 5000;
            p.ValorGanho = 3000;


            //assert
            resultado = p.obterGanhoLiquido();
            assert.equal(esperado, resultado);
        }
    }

}
