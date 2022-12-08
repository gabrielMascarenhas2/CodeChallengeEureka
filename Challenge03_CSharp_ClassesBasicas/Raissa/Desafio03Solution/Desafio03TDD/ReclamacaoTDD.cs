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
        public void situacaoReclamacao()
        {
            //Arrange
            string esperado = "Não está atrasada";
            string resultado;

            Reclamacao R = new Reclamacao();
            R.NumeroDeDiasPassado = 15;

            //Assert
            resultado = R.situacaoReclamacao();
            Assert.Equal(esperado, resultado);

        }
    }
}
