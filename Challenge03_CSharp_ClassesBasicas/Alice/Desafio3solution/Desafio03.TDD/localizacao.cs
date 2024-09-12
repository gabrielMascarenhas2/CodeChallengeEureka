using Desafio3console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03.TDD
{
    public class localizacao
    {
        private static double enderecocompleto;
        private static double enderecoCompleto;
        private static double endereco;

        
        public static double Rua  { get; private set; }
        public l.Rua RuadaVirtude { get; private set; }
        public string Estancia { get; private set; }

        [Fact]
        public void Enderecocompleto() 
        {
            // Arrange 
            double esperado = 0;
            double resultado = 0;

            localizacao l = new localizacao();
            l.rua = RuadaVirtude;
            l.cidade = Estancia;






            //Assert
            resultado = l.enderecoCompleto();
            Assert.Equal(esperado, resultado);


        }

        private static double enderecoCompleto()
        {
            throw new NotImplementedException();
        }

        private class cidade
        {
        }
    }
}
