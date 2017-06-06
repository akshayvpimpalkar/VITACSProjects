using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignAccount
{
    class Account
    {
        string name;
        float balance;

        public Account(string name, float balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void deposit(int amt)
        {
            this.balance += (float)amt;
        }
        public void display()
        {
            Console.WriteLine("Balance for {0} after deposit is : {1}", name, balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Tim", 75000.00f);
            a1.deposit(2000);
            a1.display();

            Account a2 = new Account("Nick", 36000.0f);
            a2.deposit(7000);
            a2.display();

            Account a3 = new Account("Jessy", 42000.0f);
            a3.deposit(4000);
            a3.display();
        }
    }
}
