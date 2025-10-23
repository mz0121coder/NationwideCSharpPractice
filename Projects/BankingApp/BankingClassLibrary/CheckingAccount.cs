namespace BankingClassLibrary
{
    public class CheckingAccount : BankAccount
    {
        public decimal TransactionFee { get; }

        public CheckingAccount(string accountNumber, decimal startingBalance, decimal transactionFee)
            : base(accountNumber, startingBalance)
        {
            TransactionFee = transactionFee;
        }

        public override void Withdraw(decimal amount)
        {
            decimal total = amount + TransactionFee;
            base.Withdraw(total);
        }
    }
}
