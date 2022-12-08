using Desafio03Console;
using System;
using Xunit;

namespace Desafio03TDD
{
    public class LocalizacaoTDD
    {
        [Fact]
        public void localizacaoreal()
        {

            Localizacao a = new Localizacao();
            a.Estado = "Sergipe";
            a.cidade = " Estancia";
            a.Rua = " albano franco";

            string esperado = "Sergipe Estancia albano franco";


            string resultado = a.enderecoCompleto();
            Assert.Equal(esperado, resultado);

           
                

           




        }
    }
}
