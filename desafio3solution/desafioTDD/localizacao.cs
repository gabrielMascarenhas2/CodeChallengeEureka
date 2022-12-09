using System;

namespace desafioTDD
{
    internal class localizacao
    {
        public int ID { get; internal set; }
        public int Cidade { get; internal set; }
        public int Estado { get; internal set; }
        public int Rua { get; internal set; }

        internal object enderecocompleto()
        {
            throw new NotImplementedException();
        }
    }
}