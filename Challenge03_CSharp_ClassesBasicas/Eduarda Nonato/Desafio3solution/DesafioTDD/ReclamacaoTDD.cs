using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesafioTDD
{
    public class ReclamacaoTDD
    {
        [Fact]
        public void Reclamacao()
        {
            // Arrange
            string esperado = "Reclamação está atrasada";
            string resultado;

            Reclamacao R = new Reclamacao();
            R.numeroDeDiasPassado = 30;

            // Assert
            resultado = R.situacaoReclamacao();
            Assert.Equal(esperado, resultado);
        }
    }
}
