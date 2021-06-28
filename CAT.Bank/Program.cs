using System;
using CAT.Bank.Classes;
using CAT.Bank.Enums;

namespace CAT.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, "Jeferson Pontes", 0, 0);
            
        }
    }
}