using Desafio3Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class JuizTDD
    {
        public string AnosDeTrabalho { get; private set; }

        [Fact]
        public void TempoExperiencia()
        {
            //Arrange
            string esperado = 10;
            string resultado;

            Juiz j = new Juiz  ();
            j.AnosdeTrabalho = 10; 
           
            


            //Assert 
            resultado = Juiz(); 
            Assert.Equal(esperado, resultado);
        }
}
