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
        public void RuaEstadoECidade() 
        {

            //Arrage

            string esperado = ("Estado,Cidade,Rua");
            string resultado = ("Estado,Cidade,Rua");

            Localizacao L = new Localizacao(); 
            L.Estado = "Estado";
            L.Rua = "Rua";
            L.Cidade = "Cidade";

            //Assert

            resultado = L.enderecoCompleto();
            Assert.Equal(esperado, resultado);


        
        
        
        }



    }
}
