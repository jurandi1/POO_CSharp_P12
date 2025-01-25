namespace POO_CSharp_P12.Entities
{
    //classe selada
    //class SavingsAccount : Account
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
        //método selado
        //public sealed override void Withdraw(double amount)
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}
