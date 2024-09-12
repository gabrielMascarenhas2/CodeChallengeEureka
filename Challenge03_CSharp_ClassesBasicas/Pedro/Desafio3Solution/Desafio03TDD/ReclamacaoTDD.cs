using Desafio3Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class ReclamacaoTDD
    {

        [Fact]
        public void DiasAtrasados() 
        {

            //Arrange
            bool esperado = true;
            bool resultado;

            Reclamação R = new Reclamação();
            R.NumeroDeDiasPassado = 31;

            //Assert
            resultado = R.situacaoReclamacao();
            Assert.Equal(esperado, resultado);  



        }
        



    }
}
