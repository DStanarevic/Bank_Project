using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    class Savings : Account
    {
        //fields
        protected double balance = 400.15;
        protected double minimumBalance = 500.00;

        //Properties
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        //Constructor
        public Savings()
        { }

        public Savings(int accountNumber, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
        }

        //Methods

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
            //Condition blocks withdrawal in case balance is below minimum.
            if ((balance - withdrawal) > minimumBalance)
            {
                balance -= withdrawal;
            }
            else
            {
                Console.WriteLine("This transaction would put your account below the $" + minimumBalance + " minimum balance.\nPlease choose another transaction.");
            }
        }
    }
}
