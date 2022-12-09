using Desafio3Console;
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
        public void enderecoCompleto()
        {
            //Arrange
            string esperado = "Salvador, Bahia, Menininha do Gantois"; 
            string  resultado;

            Localizacao A = new Localizacao(); 
            A.Cidade = "Salvador";
            A.Estado = "Bahia";
            A.Rua = "Menininha dos Gantois"; 


            //Assert 
            resultado = A.enderecoCompleto();
            Assert.Equal(esperado, resultado);
        }
}
