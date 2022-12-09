using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Desafio03Console;

namespace Desafio03TDD
{
    public class LocalizacaoTDD
    {
        [Fact]
        public void VerificarEndereço()
        {
            //Arrange
            string esperado = "Endereço: Sergipe, Estância, Rua Marechal Deodoro da Fonseca";

            Localizacao local = new Localizacao();
            local.Cidade = "Estância";
            local.Estado = "Sergipe";
            local.Rua = "Rua Marechal Deodoro da Fonseca";
            string resultado = local.enderecoCompleto();

            //Assert
            Assert.Equal(esperado, resultado);
        }

    }
}
