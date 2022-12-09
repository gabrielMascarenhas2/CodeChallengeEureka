using desafio3Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioTDD
{
  public class classejuizTDD
    {
        [Fact]
        public void temboaexperiencia()
        {
            //Arrange 
            bool esperado = true;

            classejuiz J = new classejuiz();
            J.anosdeTrabalho = 29;
            bool resultado = J.temBoaExperiencia();

            //assert 
            Assert.Equal(esperado, resultado,);

        }
    }
}
