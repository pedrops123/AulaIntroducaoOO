using System;
using System.Globalization;

namespace _04_CriacaoDeMetodos
{

    /// <summary>
    /// Criação de classe simples para exemplo , Model exemplo. A classe somente é um molde de estrutura de dados para utilizarmos sua copia ( Instancia )
    /// </summary>
    
    public class ContaCorrente
    {
        public string titular;
        public int numeroAgencia;
        public int numero;
        // Aqui temos uma forma de inicializar uma propriedade de uma classe
        public double saldo = 100.00;


        // Exempo simples de como criar um metodo em uma classe 
        public bool Sacar (double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        // Exemplo de função void (metodo sem retorno) feito em arrow function 
        public void Depositar(double valor) => this.saldo += valor;
        
        public override string ToString() => String.Format("O titular é {0} \n \n Numero agencia: {1} \n \n Numero da Conta: {2} \n \n Saldo: {3} ",titular ,numeroAgencia ,numero , saldo.ToString(CultureInfo.InvariantCulture));
        

        public string MostraSaldoTotal(string nomeConta) => String.Format("O saldo total da conta {1} no momento é R${0}" , this.saldo,   nomeConta);
        

        public bool Transferencia(double valor , ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}