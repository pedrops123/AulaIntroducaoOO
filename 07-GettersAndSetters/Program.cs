using System;

namespace _07_GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta._saldo = -10;

            Console.WriteLine(conta.ToString());


            conta._saldo = 1000;
            Console.WriteLine(conta.ToString());

          
        }
    }
}
