using Desafio03console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class JuizTDD
    {
        [Fact]
        public void obtertempoExperiencia()
        {
            //Arrange
            bool resultado = false;
            bool esperado = true;

            JUIZ j  = new JUIZ();

            j.AnosTrabalho = 15;

            //Assert
            resultado = j.tempoExperiencia();
            Assert.Equal(esperado, resultado);
        }


    }
}
