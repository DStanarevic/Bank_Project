using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    abstract class Account
    {
        //I set my Account class as my Abstract class, the Checking and Savings classes both inherit from it.

        //fields
        protected int accountNumber;
        protected string accountType;
        protected double withdrawal;
        protected double deposit;
        protected double balance;

        //Properties
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }

        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }

        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        //Methods

        //This method was part of my stretch task, from what I understood was that we needed to 
        //pass the Client object to the Account class and verify the users name. 
        public static void UserName(string name, Client newClient)
        {
            while (name != newClient.CustomerName)
            {
                Console.WriteLine("Please enter your name as it appears on your account.");
                name = Console.ReadLine();
            }
        }

        //Abstract Method
        public abstract void GetBalance();

        //Virtual Method
        public virtual void MakeDeposit()
        {
            balance += deposit;
        }

        //Virtual Method
        public virtual void MakeWithdrawal()
        {
            balance -= withdrawal;
        }
    }
}
