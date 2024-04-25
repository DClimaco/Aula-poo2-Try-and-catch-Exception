using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20240425
{
    internal class TioPauloException : Exception
    {
        public bool vivo { get; set; }

        public TioPauloException(bool vivo, string mensagem): base(mensagem)
        {
            this.vivo = vivo;
        }
    }
}
