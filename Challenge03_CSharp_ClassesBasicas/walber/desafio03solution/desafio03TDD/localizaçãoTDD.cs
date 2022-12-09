using desafio03console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace desafio03TDD
{
   public class localizaçãoTDD
    {
        [Fact]
        public void VerificarEndereço()
        {
            //Arrange
            string esperado = "Endereço: Sergipe, Estância, rua largo do francao"

            Localizacao local = new localização();
            local.Cidade = "Estancia";
            local.Estado = "Sergipe";
            local.Rua = "Rua largo do francao";
            string resultado = local.enderecoCompleto();

            //Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
