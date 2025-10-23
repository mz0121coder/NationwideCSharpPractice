using Xunit;
using BankingClassLibrary;

namespace BankingClassLibrary.Tests
{
    public class BusinessAccountTests
    {

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
