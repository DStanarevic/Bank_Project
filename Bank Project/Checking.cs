using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    class Checking : Account
    {
        //fields
        private double balance = 1200.87;

        //Properties
        private double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        //Constructor
        public Checking()
        { }

        public Checking(int accountNumber, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
        }

        //Method

        //Abstract Method inherited from Account.
        public override void GetBalance()
        {
            Console.WriteLine("Balance: $" + balance);
        }

        //Overriden Method inherited from Account.
        public override void MakeDeposit()
        {
            deposit = double.Parse(Console.ReadLine());
            balance += deposit;
        }

        //Overriden Method inherited from Account.
        public override void MakeWithdrawal()
        {
            withdrawal = double.Parse(Console.ReadLine());
            balance -= withdrawal;
        }
    }
}
