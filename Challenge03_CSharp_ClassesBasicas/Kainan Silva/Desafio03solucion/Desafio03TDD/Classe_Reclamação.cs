using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class Classe_Reclamação
    {
        [Fact]
        public void SituacaoReclamacao()
        {
            //Arrange 
            bool esperado = "Não atrasado";
            bool resultado;

            Classe_Reclamação c = new Classe_Reclamação();

            c.NumeroDeDiasPassado > 30;

            //Assert
            resultado = c.numerodediaspassado();
            Assert.Equal(esperado, resultado);


        }
    }
}
