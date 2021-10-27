using System;

namespace _04_CriacaoDeMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaDaPessoaX = new ContaCorrente();
            ContaCorrente ContaDaPessoaY = new ContaCorrente();

            // A conta da pessoa X inicia a instancia com a propriedade "Saldo" inicializada como 100.

            Console.WriteLine(ContaDaPessoaX.MostraSaldoTotal("X")); 

            // O Saque é efetuado com sucesso , pois o valor ainda é 100 , portando sobra 50
            bool resultSaque1 = ContaDaPessoaX.Sacar(50);
            Console.WriteLine(ContaDaPessoaX.MostraSaldoTotal("X"));
            Console.WriteLine(resultSaque1);


            // O Saque é efetuado com sucesso , pois o valor é 50 , portando sobra 0
            bool resultSaque2 = ContaDaPessoaX.Sacar(50);
            Console.WriteLine(ContaDaPessoaX.MostraSaldoTotal("X"));
            Console.WriteLine(resultSaque2);


            // O Saque não é efetuado aqui pois nao sobrou nada por conta das transações anteriores
            bool resultSaque3 = ContaDaPessoaX.Sacar(50);
            Console.WriteLine(ContaDaPessoaX.MostraSaldoTotal("X"));
            Console.WriteLine(resultSaque3);

            ContaDaPessoaX.Depositar(100);
            ContaDaPessoaX.Depositar(50);

            Console.WriteLine(ContaDaPessoaX.saldo);

            //Transferencia de valores entre contas 
            ContaDaPessoaX.Transferencia(150, ContaDaPessoaY);
            // Como o valor total da conta X é 150 aqui mostrará zerado. 
            Console.WriteLine(ContaDaPessoaX.MostraSaldoTotal("X"));
            // O saldo anterior da conta Y é 100 portanto agregara o valor dando a quantia de R$250,00. 
            Console.WriteLine(ContaDaPessoaY.MostraSaldoTotal("Y"));

            Console.ReadKey();
        }
    }
}
