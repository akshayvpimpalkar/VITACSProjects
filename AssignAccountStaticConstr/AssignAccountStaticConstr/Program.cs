using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignAccountStaticConstr
{

    class Account
    {
        int accid;
        string name;
        float balance;
        static int id;
        static float fdrate = 0.05f;

        static Account()
        {
            Console.WriteLine("Bank Of India!\n");
        }

        public Account(string name, float bal)
        {
            accid = ++id;
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
            Account a1 = new Account("Prasad", 325781.23f);
            a1.disp();
        }
    }
}
