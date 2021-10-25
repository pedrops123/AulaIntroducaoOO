using System;

namespace _02_InicializacaoClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ao chamarmos o objeto sem incluir nenhum valor , automaticamente suas propriedades já possuem um valor default
            // Como inicializamos a propriedade "saldo" com 100 , ao chamarmos o write line com o ToString da classe  , fica com o valor definido. 
            Console.WriteLine(new ContaCorrente());
        }
    }
}
