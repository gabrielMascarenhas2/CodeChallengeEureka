using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
   public  class ReclamacaoTDD
    {
        [Fact]
        public void situacaoReclamacao()
        {
            //Arrange
            string esperado = "Está atrasada";
            string resultado;

            Reclamacao R = new Reclamacao ();
            R.numeroDeDiasPassado = 40;


            //Assert
            resultado = R.situacaoReclamacao();
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void situacaoReclamacao2()
        {
            //Arrange
            string esperado = "Não está atrasado";
            string resultado;

            Reclamacao R = new Reclamacao();
            R.numeroDeDiasPassado = 15;


            //Assert
            resultado = R.situacaoReclamacao();
            Assert.Equal(esperado, resultado);
        }





    }

}
