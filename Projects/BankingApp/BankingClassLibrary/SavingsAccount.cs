namespace BankingClassLibrary
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; }

        public SavingsAccount(string accountNumber, decimal startingBalance, decimal interestRate)
            : base(accountNumber, startingBalance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            decimal interest = Balance * InterestRate;
            Deposit(interest);
        }
    }
}
