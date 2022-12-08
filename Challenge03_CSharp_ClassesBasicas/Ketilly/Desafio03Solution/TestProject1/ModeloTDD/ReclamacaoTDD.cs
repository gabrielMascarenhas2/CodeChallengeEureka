using Desafio03console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class ReclamacaoTDD
    {
        [Fact]
        public void situacaoReclamacao()
        {
            //Arrange
            string esperado = "Está atrasada";
            string resultado;

            Reclamacao R = new Reclamacao();
            R.numeroDeDiasPassado = 40;

            //Arrert
            resultado = R.SituacaoReclamacao();
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void situacaoReclamacaoO2()
        {
            //Arrange 
            string esperado = "Não está atrasado";
            string resultado;

            Reclamacao R = new Reclamacao();
            R.numeroDeDiasPassado = 15;

            //Assert
            resultado = R.SituacaoReclamacao();
            Assert.Equal(esperado, resultado);


        }
            




    }
}
