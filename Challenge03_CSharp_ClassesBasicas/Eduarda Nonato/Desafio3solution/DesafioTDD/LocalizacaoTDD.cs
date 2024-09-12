using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesafioTDD
{
    public class LocalizacaoTDD
    {
        [Fact]
        public void enderecoCompleto()
        {
            //Arrange
            string resultado = null; 
            string esperado = null;
           Localizacao L = new Localizacao();
            L.ID = 1;
            L.Cidade = null;
            L.Estado = null;
            L.Rua = null;
            //Assert
            resultado = L.obterenderecoCompleto();
            Assert.Equal(esperado, resultado);



        }
    }
}
