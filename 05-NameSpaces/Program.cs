using System;

namespace _05_NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizando classes sem necessidade de using ou explicitação direta.
            ContaCorrente conta = new ContaCorrente();
            conta.numero = 1234;
            conta.numeroAgencia = 12;

            // Podemos acessar a propriedade tipo cliente dentro do modelo ContaCorrente
         
            conta.DadosCliente.titular = "Pedro Furlan";
            conta.DadosCliente.RG = "12.123.423-2";
            conta.DadosCliente.CPF = "123.432.874-23";


            /*
             Poderiamos tambem inicializar nosso objeto Cliente  sem necessidade do construtor fazendo da seguinte forma
             
                Cliente DataCliente = new Cliente();
                DataCliente.titular = "Teste";
                DataCliente.CPF = "123.432.123-2";
                DataCliente.RG = "12.234.887.2;";
                conta.DadosCliente = DataCliente;

            */

            Console.WriteLine(conta.ToString());



            
        }
    }
}
