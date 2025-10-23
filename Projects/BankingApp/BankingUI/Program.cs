using BankingClassLibrary;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("123456", 1000);
        account.Deposit(250);
        account.Withdraw(100);

        Console.WriteLine($"Account {account.AccountNumber} has balance: ${account.Balance}");
    }
}
