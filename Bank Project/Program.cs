using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //The menu is made of 4 methods that call each other, this allowed me
            //to toggle between the options without closing the console. You can use c
            //to move back to the main menu and choose another option.

            // The 4 methods and their functions are listed below.
            // PrintMenu() - Displays Main Menu and links to other methods.
            // BalanceMenu() - Displays Balance Menu and calls back to Main Menu.
            // DepositMenu() - Displays the Deposit Menu and calls back to Main Menu.
            // WithdrawMeny() - Displays Withdrawy Menu and calls back to Main menu. 
             

            //Instantiated my objects.
            Client newClient = new Client("Dan Stan", "1234 Road Dr", 123456);
            Savings newSavings = new Savings(222333, "Savings");
            Checking newChecking = new Checking(333444, "Checking");

            PrintMenu(newClient, newChecking, newSavings);
        }

        //The main menu, this calls the 3 other methods and uses a loop to run the application.
        public static void PrintMenu(Client newClient, Checking newChecking, Savings newSavings)
        {
            Console.WriteLine("Please enter a number to choose one of the following options.");
            Console.WriteLine("1. View Client information.");
            Console.WriteLine("2. View Account Balance.");
            Console.WriteLine("3. Deposit funds.");
            Console.WriteLine("4. Withdraw funds.");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            int mainMenu = int.Parse(Console.ReadLine());

            do
            {
                //The first option calls the ViewInfo method from the Client class.
                if (mainMenu == 1)
                {
                    newClient.ViewInfo();
                    Console.WriteLine("Press enter to choose another transaction.");
                    Console.ReadLine();
                    PrintMenu(newClient, newChecking, newSavings);
                }
                //The second option calls the Balance Menu method.
                if (mainMenu == 2)
                {
                    BalanceMenu(newClient, newChecking, newSavings);
                }
                //The third option calls the Deposit Menu method.
                if (mainMenu == 3)
                {
                    DepositMenu(newClient, newSavings, newChecking);
                }
                //The fourth option calls the Withdraw Menu method.
                if (mainMenu ==4)
                {
                    WithdrawMenu(newClient, newSavings, newChecking);
                }
            }
            while (mainMenu != 5);
            Console.WriteLine("Thank you for banking with us.");
            Environment.Exit(0);
        }

        //This method displays the Balance information for both accounts. 
        //It calls back to Print Menu when you exit out of it.
        public static void BalanceMenu(Client newClient, Checking newChecking, Savings newSavings)
        {
            Console.WriteLine("Please choose a or b to specify which account you would like to view.");
            Console.WriteLine("a. Checking account balance.");
            Console.WriteLine("b. Savings account balance.");
            Console.WriteLine("c. Choose other transaction.");
            char balanceMenu = char.Parse(Console.ReadLine());

            if (balanceMenu == 'a')
            {
                newChecking.GetBalance();
                Console.WriteLine("Press enter to choose another account.");
                Console.ReadLine();
                BalanceMenu(newClient, newChecking, newSavings);
            }
            else if (balanceMenu == 'b')
            {
                newSavings.GetBalance();
                Console.WriteLine("Press enter to choose another account.");
                Console.ReadLine();
                BalanceMenu(newClient, newChecking, newSavings);
            }
            else
            {
                PrintMenu(newClient, newChecking, newSavings);
            }
        }

        //This method allows you to deposit to the two different accounts, 
        //it allows you to go back and make another selection. When you close out
        //of this method, it calls back to the Main Menu.
        public static void DepositMenu(Client newClient, Savings newSavings, Checking newChecking)
        {
            char depositMenu;
            Console.WriteLine("Please choose a or b to specify which account to deposit to.");
            Console.WriteLine("a. To Checking account.");
            Console.WriteLine("b. To Savings account.");
            Console.WriteLine("c. Choose other transaction.");
            depositMenu = char.Parse(Console.ReadLine());
            if (depositMenu == 'a')
            {
                Console.WriteLine("How much money would you like to deposit into your Checking account?");
                Console.WriteLine("Current balance on account: "); newChecking.GetBalance();
                Console.WriteLine("The amount to deposit is: "); newChecking.MakeDeposit();
                Console.WriteLine("New balance on account: "); newChecking.GetBalance();
                Console.WriteLine("Press enter to choose another account.");
                Console.ReadLine();
                DepositMenu(newClient, newSavings, newChecking);
            }
            else if (depositMenu == 'b')
            {
                Console.WriteLine("How much money would you like to deposit into your Savings account?");
                Console.WriteLine("Current balance on account:"); newSavings.GetBalance();
                Console.WriteLine("The amount to deposit is: "); newSavings.MakeDeposit();
                Console.WriteLine("New balance on account: "); newSavings.GetBalance();
                Console.WriteLine("Press enter to choose another account.");
                Console.ReadLine();
                DepositMenu(newClient, newSavings, newChecking);
            }
            else
            {
                PrintMenu(newClient, newChecking, newSavings);
            }
        }

        //The last method allows you to make withdrawals from your two accounts. Like the previous one, 
        //it allows you to go back and make another selection. It also calls back to the Main Menu
        //when you close.
        public static void WithdrawMenu(Client newClient, Savings newSavings, Checking newChecking)
        {
            char withdrawMenu;
            Console.WriteLine("Please choose a or b to specify which account to withdraw from.");
            Console.WriteLine("a. From Checking account.");
            Console.WriteLine("b. From Savings account.");
            Console.WriteLine("c. Choose other transaction.");
            withdrawMenu = char.Parse(Console.ReadLine());

            if (withdrawMenu == 'a')
            {
                Console.WriteLine("How much money would you like to withdraw from your Checking account?");
                Console.WriteLine("Current balance on account:"); newChecking.GetBalance();
                Console.WriteLine("The amount to withdraw is: "); newChecking.MakeWithdrawal();
                Console.WriteLine("New balance on account: "); newChecking.GetBalance();
                Console.WriteLine("Press enter to choose another account.");
                Console.ReadLine();
                DepositMenu(newClient, newSavings, newChecking);
            }
            else if (withdrawMenu == 'b')
            {
                Console.WriteLine("How much money would you like to withdraw from your Savings account?");
                Console.WriteLine("Current balance on account:"); newSavings.GetBalance();
                Console.WriteLine("The amount to withdraw is: "); newSavings.MakeWithdrawal();
                Console.WriteLine("New balance on account: "); newSavings.GetBalance();
                Console.WriteLine("Press enter to choose another account.");
                Console.ReadLine();
                DepositMenu(newClient, newSavings, newChecking);
            }
            else
            {
                PrintMenu(newClient, newChecking, newSavings);
            }
        }

    }
}
