using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = new bool();
            Program g = new Program();
            int r;
            string str = null;
            i = int.TryParse(null, out r);
            double n = double.Parse("12.07");
            Console.WriteLine(i + "\t" + r + "\t" + n);
            int num = 18;
            //Console.WriteLine(ref num);
            string s1 = new string(new char[] { 'a', 'b' });
            string s2 = "ab";
            Console.WriteLine("s1= " + s1);
            Console.WriteLine("s2= " + s2);
            Console.WriteLine("== is " + (s1 == s2));
            Console.WriteLine("Equals is " + s1.Equals(s2));
            Console.WriteLine("Ref equals is " + string.ReferenceEquals(s1, s2));
            string u = string.Intern(s1);
            Console.WriteLine("u= " + u);
            Console.WriteLine("ref equals s2, u is " + string.ReferenceEquals(s2, u));
        }
        



    }
}
