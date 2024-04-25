using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20240425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente cc = new ContaCorrente(13, 24, 1000, false);
                cc.sacar(100);
            }
            catch(TioPauloException ex)
            {
                Console.WriteLine($"Informação de vida:" + ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine($"Informação do objeto. Mensagem:" + ex.Message);
                Console.WriteLine($"Informação do objeto. Conta:" + ex.numConta);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Informação do objeto. Mensagem:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finalizando...");
            }
        }
    }
}
