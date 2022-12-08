using desafio3Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace desafioTDD
{
    public class processoTDD
    {
        [Fact]
        public void ValorGanhoLiquido()
        {
            //Arrange 
            double esperado = 2000;
            double resultado = -1;

            Processo p = new Processo();
            p.Valorpedido = 3000;
            p.Valorganho = 5000;



            //assert
            resultado = p.obterganholiquido();
            Assert.Equal(esperado, resultado);
        } 


    }
}
