using Desafio03Console.EscritorioModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD.EscritorioModelTDD
{
    public class ReclamacaoTDD
    {
        [Fact]
        public void ReclamacaoAtrasada()
        {
            //Arrange
            string esperado = "Reclamação Enviada";

            Reclamacao rec = new Reclamacao();
            rec.numeroDeDiasPassado = 30;
            string resultado = rec.situacaoReclamacao();

            //Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
