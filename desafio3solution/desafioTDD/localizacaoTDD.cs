using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioTDD
{
   public class localizacaoTDD
    {
        private object localizacao;
        private int aracaju;
        private int sergipe;
        private int norte;
        private object resultado;

        [Fact]
    public void enderecoCompleto()
        {
            //arrange 
            string esperado = ("aracaju, sergipe, norte");
            string resultdo = null;


            localizacao L = new localizacao();
            L.ID = 1;
            L.Cidade = aracaju;
            L.Estado = sergipe;
            L.Rua = norte; 

            //assert 
            localizacao = L.enderecocompleto();
            Assert.Equal(esperado, resultado);



                         

        }

        private void enderecocompleto()
        {
            throw new NotImplementedException();
        }
    }
}
