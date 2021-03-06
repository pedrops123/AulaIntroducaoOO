using System;
using System.Globalization;

namespace _01_ByteBank
{

    /// <summary>
    /// Criação de classe simples para exemplo , Model exemplo. A classe somente é um molde de estrutura de dados para utilizarmos sua copia ( Instancia )
    /// </summary>
    
    public class ContaCorrente
    {
        public string titular;
        public int numeroAgencia;
        public int numero;
        public double saldo;

        public override string ToString()
        {
            return String.Format("O titular é {0} \n \n Numero agencia: {1} \n \n Numero da Conta: {2} \n \n Saldo: {3} ",titular ,numeroAgencia ,numero , saldo.ToString(CultureInfo.InvariantCulture));
        }
    }
}