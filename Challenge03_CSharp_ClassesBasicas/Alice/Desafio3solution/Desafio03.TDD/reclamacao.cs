using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03.TDD
{
    public class reclamacao
    {
        private double numeroDeDiasPassado;

        [Fact] 
        public void situacaoreclamacao()
        {
            // Arrange 
            double esperado = 30;
            double resultado = -0;

            reclamacao r= new reclamacao();
            r.numeroDeDiasPassado = 20;


            //Assert
            resultado = r.situacaoReclamacao();
            Assert.Equal(esperado, resultado);


        }

        private double situacaoReclamacao()
        {
            throw new NotImplementedException();
        }
    }
}
