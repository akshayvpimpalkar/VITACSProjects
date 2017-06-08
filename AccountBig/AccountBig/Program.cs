using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBig
{
    abstract class Account
    {
        static int id;
        string _name;
        float _balance;
        int _accid;
        string _type;

        public Account(string name, float bal, string type)
        {
            _accid = ++id;
            Name = name;
            Balance = bal;
            Type = type;
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

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void deposit(float amt)
        {
            if (amt > 0)
                Balance += amt;
            else
                throw new MyException("Please enter amt > 0");
        }

        public override string ToString()
        {
            return string.Format("AccountID: {0}\nName: {1}\nBalance: {2}\nType: {3}\n", Accid, Name, Balance, Type);
        }

        abstract public void withdraw(float amt); 
    }

    class SavingAccount : Account
    {
        
        public SavingAccount(string name, float bal, string type = "Saving") : base(name, bal, type)
        {
            
        }

        public override void withdraw(float amt)
        {
            const int minbal = 10000;
            float x = Balance - amt;
            if (x >= minbal && amt > 0)
            {
                Balance -= amt;
            }
            else
            {
                throw new MyException("insufficient balance");
            }
        }
    }

    class CurrentAccount : Account
    {
        
        public CurrentAccount(string name, float bal, string type = "Current") : base(name, bal, type)
        {
            
        }

        public override void withdraw(float amt)
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
                    Console.WriteLine();
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
                    Console.WriteLine("Founded Account:");
                    Console.WriteLine(arr);
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
            Console.WriteLine(s1);
            s1.withdraw(12462.98f);
            Console.WriteLine(s1);

            c1.deposit(60.0f);
            Console.WriteLine(c1);
            c1.withdraw(124622.98f);
            Console.WriteLine(c1);

            //s2.toString();
            acc_search.search(caAccount, 2);
            //saArray.ToString();
        }
    }
}
