using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
   public class ClasseReclamaçãoTDD
    {
        [Fact]

        public void verreclacao()
        {

            verreclamacao g = new verreclamacao();
            g.Descricao = "vou ser preso por racismo";
            string esperado = "vou ser preso por racismo";

            string resultado = g.situacaoreclamacao();
            Assert.Equal(esperado, resultado);

    }
}
