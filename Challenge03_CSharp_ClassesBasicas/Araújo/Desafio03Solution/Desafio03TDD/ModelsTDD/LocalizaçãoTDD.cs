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
        public void EnderecoCompleto()
        {
            //Arrange 
            string esperado = ("SergipeEstânciaRuajoséMirandadeCarvalho");
            string resultado;

            Localizacao local = new Localizacao();
            local.Estado = ("Sergipe");
            local.Cidade = ("Estância");
            local.Rua = ("RuajoséMirandadeCarvalho");

            resultado = local.EnderecoCompleto();

            //Assert 
            Assert.Equal(esperado, resultado);


        }

    }
}
