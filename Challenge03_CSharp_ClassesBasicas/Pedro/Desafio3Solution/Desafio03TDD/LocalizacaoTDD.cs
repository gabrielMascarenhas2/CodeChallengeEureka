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

            string esperado = ("CidadeEstadoRua");
            string resultado = ("CidadeEstadoRua");

            Localizacao L = new Localizacao();
            L.Cidade = "Cidade";
            L.Rua = "Rua";
            L.Estado = "Estado";
           
            

            //Assert

            resultado = L.enderecoCompleto();
            Assert.Equal(esperado, resultado);


        
        
        
        }



    }
}
