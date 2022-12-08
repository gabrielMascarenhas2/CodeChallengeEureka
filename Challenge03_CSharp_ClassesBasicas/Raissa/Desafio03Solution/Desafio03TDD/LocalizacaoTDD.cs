using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class LocalizacaoTDD
    {
        [Fact]
        public void EnderecoCompleto()
        {
            //Arrange

            string esperado = ("SergipeEstanciaLuizDaCosta");
            string resultado;

            Localizacao L = new Localizacao();

            L.Estado = ("Sergipe");
            L.Cidade = ("Estancia");
            L.Rua = ("LuizDaCosta");

            //Assert

            resultado = L.EnderecoCompleto();
            Assert.Equal(esperado, resultado);

        }
    }
}
