using System;

namespace Lab02
{
    public class Program
    {
        public static decimal Balance = 5000;
        public static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            // I declared these to use for the while loop so the application keeps running until the user wants to exit
            string userChoice = "";
            string userYorN = "";

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
                        // Deposit(Balance, amount);
                        Console.WriteLine($"Thank you! Depositting... ${amount}");
                        Console.WriteLine("Would you like another transaction (y/n)?");
                        //used .toLower to weed out some user error
                        userYorN = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, please enter a positive and valid decimal number");
                    }
                }
                if (userChoice == "2")
                {
                    Console.WriteLine("How much would you like to withdraw today?");
                    string amountInput = Console.ReadLine();
                    decimal amount = Convert.ToDecimal(amountInput);
                    //Makes sure the input is a positive number
                    if (amount > 0)
                    {
                        //Withdraw(Balance, amount)
                        Console.WriteLine($"Thank you! Withdrawing... ${amount}");
                        Console.WriteLine("Would you like another transaction?");
                        userYorN = Console.ReadLine().ToLower();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, please enter a positive and valid decimal number");
                    }
                }
                if (userChoice == "3")
                {
                    Console.WriteLine($"Here is your balance: ${Balance}");
                    Console.WriteLine("Would you like another transaction?");
                    userYorN = Console.ReadLine().ToLower();
                }

            }
        }

            public static decimal ViewBalance(decimal currentBallance)
            {
                return Balance;
            }

    }
}
