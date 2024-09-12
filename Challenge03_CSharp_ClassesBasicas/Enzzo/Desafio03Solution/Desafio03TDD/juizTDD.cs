using Desafio03Console;
using System;
using Xunit;

namespace Desafio03TDD
{
    public class JuizTDD
    {
        [Fact]
        public void ExperienciaJuiz()
        {
            string esperado = "tem experiencia";

            Juiz a = new Juiz();
            a.anostrabalho = 11;

            string resultado = a.temBoaExperiencia();
            Assert.Equal(esperado, resultado);
                

           




        }
    }
}
