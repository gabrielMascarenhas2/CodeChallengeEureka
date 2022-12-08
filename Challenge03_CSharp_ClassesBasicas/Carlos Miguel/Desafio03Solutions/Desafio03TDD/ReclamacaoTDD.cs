using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class ReclamacaoTDD
    {
        [Fact]
        public void ReclamacaoigualAtrasado()
        {
            //Arrange
            string esperado = "Atrasado";
            string resultado; 

            Reclamacao r = new Reclamacao();
            r.numeroDeDiasPassado = 31;

            //Assert
            resultado = r.situacaoReclamacao();
            Assert.Equal(esperado, resultado);
        }
    }
}
