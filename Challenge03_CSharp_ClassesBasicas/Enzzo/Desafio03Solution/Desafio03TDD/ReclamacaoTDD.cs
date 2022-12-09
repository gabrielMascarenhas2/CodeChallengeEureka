using Desafio03Console;
using System;
using Xunit;

namespace Desafio03TDD
{
    public class reclamacaoTDD
    {
        [Fact]
        public void verreclamacao()
        {

            
            reclamacao v = new reclamacao();
            v.Descricao = "odeio vc, estou na cadeia agora seu inutil";
            string esperado = "odeio vc, estou na cadeia agora seu inutil";

            string resultado = v.situacaoReclamacao();
            Assert.Equal(esperado, resultado);





        }
    }
}
