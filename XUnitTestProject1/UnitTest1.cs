using System;
using Xunit;
using Lab02;

namespace Lab02Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceTestWorking()
        {
            decimal balance = Program.Balance;
            decimal result = Program.ViewBalance(balance);
            Assert.Equal(Program.Balance, result);

        }

        [Fact]
        public void ViewBalanceTestNotWorking()
        {
            decimal balance = 5000;
            decimal result = Program.ViewBalance(balance);
            Assert.NotEqual(42, result);

        }

        [Fact]
        public void DepositTestWorking()
        {
            decimal balance = Program.Balance;
            decimal result = Program.Deposit(balance);
            Assert.Equal(Program.Balance, result);
        }


        [Fact]
        public void DepositTestNotWorking()
        {
            decimal balance = 1500;
            decimal result = Program.Deposit(balance);
            Assert.NotEqual(96, result);
        }

        [Fact]
        public void WithdrawTestWorking()
        {
            decimal balance = Program.Balance;
            decimal result = Program.Withdraw(balance);
            Assert.Equal(Program.Balance, result);
        }


        [Fact]
        public void WithdrawTestNotWorking()
        {
            decimal balance = 300;
            decimal result = Program.Withdraw(balance);
            Assert.NotEqual(400, result);
        }
    }
}
