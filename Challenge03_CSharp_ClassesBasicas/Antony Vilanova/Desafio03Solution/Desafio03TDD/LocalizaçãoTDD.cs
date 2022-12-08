using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
   public class LocalizaçãoTDD
    {
        [Fact]
        public void enderecoCompleto()
        {
            //Arrange
            string esperado = "EstanciaSergipeRua Antonio Carlos Valadares";
            string resultado;

            Classe_Localização L = new Classe_Localização();
            L.Cidade = "Estancia";
            L.Estado = "Sergipe";
            L.Rua = "Rua Antonio Carlos Valadares";

            //Assert
            resultado = L.enderecoCompleto();
            Assert.Equal(resultado, esperado);
        }
    }
}
