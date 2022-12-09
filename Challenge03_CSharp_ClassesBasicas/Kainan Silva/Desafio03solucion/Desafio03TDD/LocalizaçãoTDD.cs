using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class LocalizaçãoTDD
    {
        [Fact]
        public void EndereçoCompleto()
        {
            //Arrange
            string esperado = "Estancia, sergipe, recife";
            string resultado = "Cidade, Rua, Estado";       

            LocalizaçãoTDD L = new LocalizaçãoTDD();
                L.Cidade = "Estancia";
                L.Estado = "Sergipe";
                L.Rua = "recife";



        }
    }
}
