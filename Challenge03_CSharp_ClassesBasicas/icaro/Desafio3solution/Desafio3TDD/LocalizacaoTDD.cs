using Desafio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio3TDD
{
    public class LocalizacaoTDD
    {
        [Fact]
        public void enderecoCompletoExample()
        {
            //Arrange
            string esperado = "Aracaju, Sergipe, Rua Albano Franco";
            string resultado = null;

            Localizacao X = new Localizacao();
            X.Cidade = "Aracaju, ";
            X.Estado = "Sergipe, ";
            X.Rua = "Rua Albano Franco";


            //Assert
            resultado = X.enderecoCompleto();
            Assert.Equal(esperado, resultado);
        }
    }
}
