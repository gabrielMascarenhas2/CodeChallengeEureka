using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioTDD
{
    class reclamacaoTDD
    {
        [fact] 
        public void Reclamacao()
        {
            //arrange 
            string esperado = "Reclamação está atrasada";
            string resultado;

            Reclamacao R = new Reclamacao();
            R.numeroDeDiasPassados = 30;

            //assert 
            resultado = R.Reclamacao();
            Assert.Equal(esperado, resultado);
        }
            
    }
}
