using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignAccountRestrict
{
    class Account
    {
        int accid;
        string name;
        float balance;
        static int id;

        static Account()
        {
            Console.WriteLine("Bank Of India!\n");
        }

        public Account(string name, float bal)
        {
            accid = ++id;
            if (accid >= 4)
            {
                throw new Exception("Can't create object!");
            }
            this.name = name;
            balance = bal;
        }

        public void disp()
        {
            Console.WriteLine("Account id : {0}\nName: {1}\nBalance: {2}\n", accid, name, balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("Suraj", 82226.237f);
            a.disp();
            Account a1 = new Account("Ashish", 271862.237f);
            a1.disp();
            Account a2 = new Account("Keshav", 82226.237f);
            a2.disp();
            Account a3 = new Account("Aditya", 82226.237f);
            a3.disp();
        }
    }
}
