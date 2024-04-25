using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20240425
{
    internal class ContaCorrente
    {
        public int agencia;
        public int numero;
        public double saldo;
        public bool vivo;

        public ContaCorrente(int agencia, int numero, double saldo, bool vivo)
        {
            this.agencia = agencia;
            this.numero = numero;
            this.saldo = saldo;
            this.vivo = vivo;
        }

        public void sacar(double valor)
        {
            if(vivo == false)
            {
                Console.WriteLine("Chame a polícia");
                throw new TioPauloException(vivo, "Tio Paulo está morto");
            }
            else
            {
                if (saldo < valor)
                {
                    Console.WriteLine("Impossivel.");
                    throw new SaldoInsuficienteException(numero, "Sem saldo.");
                }
                else
                {
                    saldo -= valor;
                }
            }
        }
    }
}
