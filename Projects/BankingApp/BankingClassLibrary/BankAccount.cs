namespace BankingClassLibrary
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, decimal startingBalance)
        {
            AccountNumber = accountNumber;
            Balance = startingBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit must be positive.");

            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds.");
            
            Balance -= amount;
        }
    }
}
