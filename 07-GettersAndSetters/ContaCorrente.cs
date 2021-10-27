﻿using System;
using System.Globalization;

//Utilizando using
using _07_GettersAndSetters;

namespace _07_GettersAndSetters
{

    /// <summary>
    /// Criação de classe simples para exemplo , Model exemplo. A classe somente é um molde de estrutura de dados para utilizarmos sua copia ( Instancia )
    /// </summary>
    
    public class ContaCorrente
    {
        // Foi necessario a criação de um contrutor para inicializar a propriedade com tipo complexo. Uma vez inicializada , conseguimos utilizar normalmente.
        public ContaCorrente()
        {
            DadosCliente = new Cliente();
        }
        // Podemos chamar uma classe diretamente pelo seu NameSpace
        //_05_NameSpaces.Cliente DadosCliente;

        // Ou podemos utilizar o using para deixar o namespace "global" para a classe em especifico , assim qualquer classe dentro do 
        // namespace pode ser chamado sem necessidade de explicitar o namespace antes.
        // Obs : Quando se utiliza uma classe do mesmo namespace que quer utilizar , nao é necessario utilizar using nem explicitar diretamente
        // Este foi um exemplo basico de composições de classes
       public Cliente DadosCliente;

        public int numeroAgencia;
        public int numero;
        private double saldo = 100;


        // Podemos fazer um get set na propriedade , removendo a necessidade de criarmos funcoes de get e set para inserir na propriedade um valor ou recuperar um valor
        public double _saldo { 

            get { return this.saldo; } 
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this.saldo = value;
                }
            } 
        }


        // Exempo simples de como criar um metodo em uma classe.
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

        // Exemplo de função void (metodo sem retorno) feito em arrow function.
        public void Depositar(double valor) {
            if (valor > 0)
            {
                return;
            }
            else
            {
                this.saldo += valor;
            }
         }
        
        public override string ToString() => String.Format("O titular é {0} \n \n Numero agencia: {1} \n \n Numero da Conta: {2} \n \n Saldo: {3} ",DadosCliente.titular ,numeroAgencia ,numero , saldo.ToString(CultureInfo.InvariantCulture));
        

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