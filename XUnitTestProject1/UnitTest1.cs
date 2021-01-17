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
        public void DepositTestWorking()
        {
            decimal balance = Program.Balance;
            decimal result = Program.Deposit(balance);
            Assert.Equal(Program.Balance, result);
        }


        [Fact]
        public void Cant_Deposit_Negative()
        {
            Program.Balance = 1000;
            decimal result = Program.Deposit(-500);
            Assert.NotEqual(500, result);
        }

        [Fact]
        public void Cannot_Over_Withdraw()
        {
            Program.Balance = 400;
            decimal result = Program.Withdraw(700);
            Assert.Equal(0, result);
        }


        [Fact]
        public void WithdrawTestWorking()
        {
            Program.Balance = 500;
            decimal amount = 300;
            decimal result = Program.Withdraw(amount);
            Assert.Equal(200, result);
        }
    }
}
