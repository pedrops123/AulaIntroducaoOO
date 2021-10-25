using System;

namespace _01_ByteBank
{

    /// <summary>
    /// Classe principal
    /// </summary>
    
    class Program
    {

        /// <summary>
        /// Metodo principal da classe
        /// </summary>
        static void Main(string[] args)
        {


            // Instancia de classe para exemplo.
            new ContaCorrente();
            // Utilizando desta forma o codigo nao sabe de quem é esse "numero"
            //numero = 1;



            // Fazendo a instancia agregando numa variavel do tipo ContaCorrente ,
            // conseguimos inserir valor nos atributos dos objetos.
            ContaCorrente ContaDaPessoa = new ContaCorrente();
            ContaDaPessoa.titular = "Pedro da Silva";
            ContaDaPessoa.numeroAgencia = 234;
            ContaDaPessoa.numero = 1;
            ContaDaPessoa.saldo = 100.00;

            Console.WriteLine(ContaDaPessoa.ToString());


        }
    }
}
