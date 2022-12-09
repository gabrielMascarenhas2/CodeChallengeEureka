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
        public void VerificarEndereço()
        { 
            //Arrange
            string esperado = "Endereço: Sergipe, Estância, Rua E loteamento São Domingos"

            Localização local = new Localizacao();
            local.Cidade = "Estância";
            local.Estado = "Sergipe";
            local.Rua = "Rua E loteamento São Domingos";
            string resultado = local.enderecoCompleto();

            //Assert
            Assert.Equal(esperado, resultado);
    }
}
