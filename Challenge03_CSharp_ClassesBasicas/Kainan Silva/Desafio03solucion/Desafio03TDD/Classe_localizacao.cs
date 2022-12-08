using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class Classe_localizacao
    {
        [Fact]
        public void EndereçoCompleto()
        {
            //Arrange
            string esperado = "Estancia, recife, sergipe";
            string resultado;

            Classe_localizacao c = new Classe_localizacao();
            c.Cidade = "estancia";
            c.Estado = "Sergipe";
            c.Rua = "Rua Recife";

            //Assert
            resultado = c.EndereçoCompleto();
            Assert.Equal(resultado, esperado);

        }
         
    }
}
