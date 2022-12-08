using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD.ModelsTDD
{
    public class ReclamacaoTDD
    {
        [Fact]
        public void ReclamacaoAtual()
        {
            //Arrange 
            string esperado = "Reclamação está Válida";
            string resultado;

            Reclamacao r = new Reclamacao();
            r.NumeroDeDiasPassado = 30;

            //Assert 
            resultado = r.ReclamacaoAtual();
            Assert.Equal(esperado, resultado);


        }
    }
}
