﻿using Desafio03Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Desafio03TDD
{
    public class ProcessoTDD
    {
        [Fact]
        public void VAlorLiquidoIgual1000()
        {
            //Arrange 
            double esperado = 2000;
            double resultado = -1;

            Processo p = new Processo();
            p.ValorPerdido = 5000;
            p.ValorGanho = 3000;

            //Assert
            resultado = p.obterGanhoLiquido();
            Assert.Equal(esperado, resultado);
        }
    }
}
