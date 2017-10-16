using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    class Client
    {
        //fields
        protected string customerName;
        protected string customerAddress;
        protected int uniqueIdentifier;

        //Properties
        public string CustomerName
        {
            get { return this.customerName; }
            set { this.customerName = value; }
        }

        public string CustomerAddress
        {
            get { return this.customerAddress; }
            set { this.customerAddress = value; }
        }

        public int UniqueIdentifier
        {
            get { return this.uniqueIdentifier; }
            set { this.uniqueIdentifier = value; }
        }

        //Constructor
        public Client()
        { }

        public Client(string customerName, string customerAddress, int uniqueIdentifier)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.uniqueIdentifier = uniqueIdentifier;
        }

        //Method
        public void ViewInfo()
        {
            Console.WriteLine("The users information is: ");
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Customer Address: " + customerAddress);
            Console.WriteLine("Customer ID: " + uniqueIdentifier);
        }
    }
}
