using Xunit;
using BankingClassLibrary;

namespace BankingClassLibrary.Tests
{
    public class CheckingAccountTests
    {

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
    }
  }
