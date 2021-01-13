using System;
using Xunit;
using Lab02;

namespace Lab02Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceTest()
        {
            decimal balance = Program.Balance;
            decimal result = Program.ViewBalance(balance);
            Assert.Equal(Program.Balance, result);

        }
    }
}
