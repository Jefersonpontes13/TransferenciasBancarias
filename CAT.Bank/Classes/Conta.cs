using System;
using CAT.Bank.Enums;

namespace CAT.Bank.Classes
{
    public class Conta
    {
        private TipoConta TipoConta {get; set; }
        private string Nome { get; set; }
        private double Saldo {get; set; }
        private double Credito {get; set; }


        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this.TipoConta = tipoConta;
            this.Nome = nome;
            this.Saldo = saldo;
            this.Credito = credito;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo -valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }
    }
}