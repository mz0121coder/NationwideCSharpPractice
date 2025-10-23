using Xunit;
using BankingClassLibrary;

namespace BankingClassLibrary.Tests
{
    public class SavingsAccountTests
    {
        [Fact]
        public void ApplyInterest_IncreasesBalance()
        {
            SavingsAccount savings = new SavingsAccount("SAV-001", 1000, 0.05m); // 5% interest
            savings.ApplyInterest();
            Assert.Equal(1050, savings.Balance);
        }
    }
}
