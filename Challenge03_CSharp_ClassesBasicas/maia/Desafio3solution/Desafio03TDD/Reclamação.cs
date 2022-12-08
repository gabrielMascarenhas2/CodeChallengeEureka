using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class Reclamação
    {
        private int numeroDeDiasPassado;

        [Fact]
        public void Reclamacao()
        {
            //Arrange
            string esperado = "A reclamação esta atrasada";
            string resultado;

            Reclamação R  = new Reclamação();
            R.numeroDeDiasPassado = 31;

            //Assert 
            resultado = R.Reclamacao();
            Assert.Equal(esperado, resultado);
        }
    }
}
