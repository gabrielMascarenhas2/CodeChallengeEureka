using System;

namespace Desafio03TDD
{
    internal class Processo
    {
        public int ValorPedido { get; internal set; }
        public int ValorGanho { get; internal set; }

        internal double obterGanhoLiquido()
        {
            throw new NotImplementedException();
        }
    }
}