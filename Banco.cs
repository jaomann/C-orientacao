namespace CsOrientado
{
    class Banco
    {
        public string OwnerName;
        private double _accountNumber;
        public double Numero => _accountNumber;
        private double FirstDeposit;
        public double Saldo => FirstDeposit;
        public double Deposito
        {
            set
            {
                FirstDeposit += value;
            }
        }
        public double Saque
        {
            set
            {
                FirstDeposit -= value;
                FirstDeposit -= 5;
                System.Console.WriteLine("Descontamos os 5 reais de taxa viu.");
            }
        }
        public Banco()
        {

        }
        public Banco(string OwnerName, double accountNumb)
        {
            this.OwnerName = OwnerName;
            this._accountNumber = accountNumb;
        }
        public Banco(string OwnerName, double accountNumb, double FirstDeposit)
        {
            this.OwnerName = OwnerName;
            this._accountNumber = accountNumb;
            this.FirstDeposit = FirstDeposit;
        }

    }
}
