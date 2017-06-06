using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignAdd
{
    class Mymath
    {
        public static void add(int a, int b)
        {
            Console.WriteLine("The {0} + {1} = {2}", a, b, a + b);
        }

        public static void add(float a, float b)
        {
            Console.WriteLine("The {0} + {1} = {2}", a, b, a + b);
        }

        public static void add(char a, char b)
        {
            Console.WriteLine("The {0} + {1} = {2}", a, b, a + b);
        }

        public static void add(double a, double b)
        {
            Console.WriteLine("The {0} + {1} = {2}", a, b, a + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mymath.add(5, 9);
            Mymath.add(23.7f, 19.97f);
            Mymath.add('A', 'U');
            Mymath.add(67.92, 723.44);
        }
    }
}
