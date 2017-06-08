using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigAccount
{
    abstract class Account
    {
        static int id;
        string _name;
        float _balance;
        int _accid;

        public Account(string name, float bal)
        {
            _accid = ++id;
            this._name = name;
            this._balance = bal;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public int Accid
        {
            get
            {
                return _accid;
            }
        }

        public void deposit(float amt)
        {
            Balance += amt;
        }

        public void toString()
        {
            Console.WriteLine("AccountID: {0}\nName: {1}\nBalance: {2}\n", _accid, Name, Balance);
        }
    }

    class SavingAccount : Account
    {
        string type;
        public SavingAccount(string name, float bal) : base(name, bal)
        {
            type = "Saving";
        }

        public void withdrow(float amt)
        {
            const int minbal = 10000;
            float x = Balance - amt;
            if (x >= minbal)
            {
                Balance -= amt;
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
    }

    class CurrentAccount : Account
    {
        string type;
        public CurrentAccount(string name, float bal) : base(name, bal)
        {
            type = "Current";
        }

        public void withdrow(float amt)
        {
            Balance -= amt;
        }
    }
    static class acc_search
    {
        public static void search(SavingAccount[] sa, int id)
        {
            int flag = 0;

            foreach (SavingAccount arr in sa)
            {
                if (id == arr.Accid)
                {
                    Console.WriteLine("Founded Account:");
                    arr.toString();
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Saving Account not found!");
            }
        }

        public static void search(CurrentAccount[] ca, int id)
        {
            int flag = 0;

            foreach (CurrentAccount arr in ca)
            {
                if (id == arr.Accid)
                {
                    Console.WriteLine("Founded Account:\n");
                    arr.toString();
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Current Account not found!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Account[] a = new Account[3];
            SavingAccount s1 = new SavingAccount("Akshay", 56000.09f);
            CurrentAccount c1 = new CurrentAccount("Prasad", 45000.26f);
            SavingAccount s2 = new SavingAccount("Suraj", 27389.872f);

            SavingAccount[] saArray = new SavingAccount[2] { s1, s2 };
            CurrentAccount[] caAccount = new CurrentAccount[1] { c1 };

            //foreach(Account arr in a)
            //{
            //    arr.toString();
            //}

            s1.deposit(60.0f);
            s1.toString();
            s1.withdrow(12462.98f);
            s1.toString();

            c1.deposit(60.0f);
            c1.toString();
            c1.withdrow(124622.98f);
            c1.toString();

            //s2.toString();
            acc_search.search(caAccount, 2);
            //saArray.ToString();
        }
    }
}
