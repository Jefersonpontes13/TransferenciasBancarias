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
    }
}