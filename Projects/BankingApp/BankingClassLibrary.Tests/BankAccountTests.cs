using Xunit;
using BankingClassLibrary;

namespace BankingClassLibrary.Tests
{
    public class BankAccountTests
    {

        [Fact]
        public void Deposit_IncreasesBalance()
        {
            BankAccount account = new BankAccount("123", 100);
            account.Deposit(50);
            Assert.Equal(150, account.Balance);
        }

        [Fact]
        public void Withdraw_DecreasesBalance()
        {
            BankAccount account = new BankAccount("123", 200);
            account.Withdraw(75);
            Assert.Equal(125, account.Balance);
        }

        [Fact]
        public void Withdraw_TooMuch_Throws()
        {
            BankAccount account = new BankAccount("123", 50);
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
        }
    }
}
