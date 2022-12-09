using Desafio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio3TDD
{
    public class ReclamacaoTDD
    {
        [Fact]
        public void situacaoReclamacaoExample()
        {
            //Arrange
            int esperado = 31;
            int resultado = 0;

            Reclamacao F = new Reclamacao();
            F.numeroDeDiasPassado = 72;


            //Assert
            string v = F.situacaoReclamacao();
            resultado = v;
            Assert.Equal(esperado, resultado);
        }
    }
}
