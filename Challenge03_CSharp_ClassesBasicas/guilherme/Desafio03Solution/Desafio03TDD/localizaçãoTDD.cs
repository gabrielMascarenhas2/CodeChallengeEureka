using Desafio03console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
   public class localizaçãoTDD
    {
        [Fact]
        public void verificarEndereço()
        { 
            //Arrange
            string esperado = "endereço: Sergipe,Estância,Rua da bahia"

            Localização local = new Localização();
            local.Cidade = "Estância";
            local.Estado = "Sergipe";
            local.Rua = "Rua da bahia"
            string resultado = local.enderecoCompleto();

            //Assert
            assert.equal(esperado, resultado);
    }
}
