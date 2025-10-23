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

        [Fact]
        public void ApplyInterest_IncreasesBalance()
        {
            SavingsAccount savings = new SavingsAccount("SAV-001", 1000, 0.05m); // 5% interest
            savings.ApplyInterest();
            Assert.Equal(1050, savings.Balance);
        }

        // ---------------------------
        // CheckingAccount Tests
        // ---------------------------
        [Fact]
        public void Withdraw_IncludesTransactionFee()
        {
            CheckingAccount checking = new CheckingAccount("CHK-001", 500, 2.50m);
            checking.Withdraw(100); // total = 100 + 2.50 = 102.50
            Assert.Equal(397.50m, checking.Balance);
        }

        [Fact]
        public void Withdraw_TooMuch_WithFee_Throws()
        {
            CheckingAccount checking = new CheckingAccount("CHK-002", 100, 10);
            Assert.Throws<InvalidOperationException>(() => checking.Withdraw(95)); // total = 105
        }

        // ---------------------------
        // BusinessAccount Tests
        // ---------------------------
        [Fact]
        public void Withdraw_WithinCreditLimit_Succeeds()
        {
            BusinessAccount business = new BusinessAccount("BUS-001", 0, 500);
            business.Withdraw(300); // within credit limit
            Assert.Equal(-300, business.Balance);
        }

        [Fact]
        public void Withdraw_BeyondCreditLimit_Throws()
        {
            BusinessAccount business = new BusinessAccount("BUS-002", 100, 200);
            Assert.Throws<InvalidOperationException>(() => business.Withdraw(400)); // would go to -300
        }
    }
}
