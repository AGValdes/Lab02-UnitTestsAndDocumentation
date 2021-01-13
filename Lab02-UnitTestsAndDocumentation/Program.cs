using System;

namespace Lab02
{
    public class Program
    {
        public static decimal Balance = 0;

        public static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            // I declared these to use for the while loop so the application keeps running until the user wants to exit
            string userChoice = "";
            string userYorN = "";
            string moreTransactions = "Would you like another transaction (y/n)?";
            string ensureValidType = "Sorry, please enter a positive and valid decimal number";
            while (userChoice != "4" && userYorN != "n") 
            {
                Console.WriteLine("Please Select A Transaction...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. Exit");

                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.WriteLine("How much would you like to deposit today?");
                    string amountInput = Console.ReadLine();
                    decimal amount = Convert.ToDecimal(amountInput);
                    //Makes sure the input is a positive number
                    if (amount > 0)
                     {
                        Deposit(amount);
                        Console.WriteLine($"Thank you! Depositting... ${amount}");
                        Console.WriteLine(moreTransactions);
                        //used .toLower to weed out some user error
                        userYorN = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        Console.WriteLine(ensureValidType);
                    }
                }
                if (userChoice == "2")
                {
                    Console.WriteLine("How much would you like to withdraw today?");
                    string amountInput = Console.ReadLine();
                    decimal amount = Convert.ToDecimal(amountInput);
                    //Makes sure balance cannot go below 0
                    if (Balance - amount < 0)
                    {
                        Console.WriteLine($"Sorry, you do not have enough funds in this account, your balance is currently: ${Balance}");
                    }
                    //Makes sure the input is a positive number
                    else if (amount > 0 && Balance - amount > 0)
                    {
                        Withdraw(amount);
                        Console.WriteLine($"Thank you! Withdrawing... ${amount}");
                        Console.WriteLine(moreTransactions);
                        userYorN = Console.ReadLine().ToLower();
                    }
                    //Makes sure they enter a positive decimal
                    else
                    {
                        Console.WriteLine(ensureValidType);
                    }
                }
                if (userChoice == "3")
                {
                    Console.WriteLine($"Here is your balance: ${Balance}");
                    Console.WriteLine(moreTransactions);
                    userYorN = Console.ReadLine().ToLower();
                }

            }
        }

       public static decimal ViewBalance(decimal currentBallance)
       {
            decimal balance = Balance;
           return balance;
       }
        public static decimal Deposit(decimal amount)
        {
           decimal newBalance = Balance + amount;
            Balance = newBalance;
            return newBalance;

        }

        public static decimal Withdraw (decimal amount)
        {
      
                decimal newBalance = Balance - amount;
                Balance = newBalance;
                return newBalance;
            
          
        }
    }
}
