using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20240425
{
    internal class SaldoInsuficienteException : Exception
    {
        public int numConta { get; set; }

        public SaldoInsuficienteException(int numConta, string mensagem): base(mensagem)
        {
            this.numConta = numConta;
        }
    }
}
