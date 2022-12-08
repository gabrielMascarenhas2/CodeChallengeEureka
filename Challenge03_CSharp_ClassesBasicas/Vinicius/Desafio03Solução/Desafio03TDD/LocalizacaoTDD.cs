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
        public void enderecoCompleto()
        {
            //Arrange
            string esperado = ("EstânciaSergipeMorte");
            string resultado;

            Localizacao p = new Localizacao();
            p.Cidade = ("Estância");
            p.Estado = ("Sergipe");
            p.Rua = ("Voluntários Da Patria");


            //Assert
            resultado = p.enderecoCompleto();
            Assert.Equal(esperado, resultado);
        }
    }


    
    
}
