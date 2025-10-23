namespace BankingClassLibrary
{
    public class BusinessAccount : BankAccount
    {
        public decimal CreditLimit { get; }

        public BusinessAccount(string accountNumber, decimal startingBalance, decimal creditLimit)
            : base(accountNumber, startingBalance)
        {
            CreditLimit = creditLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive.");

            if (Balance - amount < -CreditLimit)
                throw new InvalidOperationException("Credit limit exceeded.");

            Balance -= amount; 
        }
    }
}
