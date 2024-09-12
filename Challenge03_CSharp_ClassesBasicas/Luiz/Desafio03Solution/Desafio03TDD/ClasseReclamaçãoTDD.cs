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
        public void verreclamacao()
        {

            verreclamacao h = new verreclamacao();
            h.Descricao = "estou preso por causa de você";
            string esperado = "estou preso por causa de você";

            string resultado = h.situacaoReclamacao();
            Assert.Equal(esperado, resultado);
    }
}
