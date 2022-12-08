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
        public void endereçoCompletoIgualEstanciaSergipeLeite()
        {
            //Arrange
            string esperado = "EstanciaSergipeLeite";
            string resultado;

            Localizacao l = new Localizacao();
            l.Cidade = "Estancia";
            l.Estado = "Sergipe";
            l.Rua = "Leite";

            //Assert
            resultado = l.enderecoCompleto();
            Assert.Equal(esperado, resultado);
        }
    }
}
