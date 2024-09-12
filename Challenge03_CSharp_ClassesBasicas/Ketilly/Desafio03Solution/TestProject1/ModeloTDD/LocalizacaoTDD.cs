using Desafio03console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class LocalizacaoTDD
    {
       [Fact]
       public void tempoExperiencia()
       {
            //Arrange 
            string esperado = ("AracajuSergipeAtalaia");
            string resultado;

            Localizacao l = new Localizacao();
            l.Cidade = ("Aracaju");
            l.Estado = ("Sergipe");
            l.Rua = ("Atalaia");

            //Assert
            resultado = l.enderecoCompleto();
            Assert.Equal(esperado, resultado);
       }





    }
}
