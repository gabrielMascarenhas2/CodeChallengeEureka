using desafio03console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace desafio03TDD
{
    public class ReclamacaoTDD
    {
        [Fact]
        public void boaExperiencia()
        {
            Reclamacao vb = new Reclamacao();
            vb.Descricao = "gostei do trabalho";
            string esperado = "gostei do trabalho";
            string resultado = vb.situacaoReclamacao();
            Assert.Equal(esperado, resultado);



        }
    }
}