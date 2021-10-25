using System;

namespace _03_TipoReferenciaEValor
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaPessoa1 = new ContaCorrente();
            contaPessoa1.titular = "Teste";
            contaPessoa1.numero = 123456;
            contaPessoa1.numeroAgencia = 461;
            contaPessoa1.saldo = 100.00;

            ContaCorrente contaPessoa2 = new ContaCorrente();
            contaPessoa2.titular = "Teste";
            contaPessoa2.numero = 123456;
            contaPessoa2.numeroAgencia = 461;
            contaPessoa2.saldo = 100.00;

            // O valor será falso pois , esta comparação esta verificando a instancia de objeto em si , ou seja , a referencia em memoria do objeto
            // e não os valores dentro de cada um.
            Console.WriteLine("Validacao de objetos diferentes " + (contaPessoa1 == contaPessoa2));

            contaPessoa2 = contaPessoa1;

            // Agora o valor será verdadeiro pois agregamos o valor de objeto da pessoa 1 para pessoa 2 , ambos estao apontando para mesma referencia.
            Console.WriteLine("Validacao de objetos iguais " + (contaPessoa1 == contaPessoa2));

            Console.ReadKey();
            Console.WriteLine("Fim da execução do programa ...");

        }
    }
}
