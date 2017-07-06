using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {

        static int b;

        static void Main(string[] args)
        {

            var v = 23;
            int num = 25;
            Console.WriteLine(v.GetType());
            Myclass m = new Myclass();
            const int a = 5;
            b = 8;
            //Console.WriteLine("m = "+ m.foo);//works for nonstatic readonly
            Console.WriteLine("m static readonly = " + Myclass.foo);
            int[] arr = new int[5] { 34, 89, 12, 90, 169 };
            Console.WriteLine("arr before sort = ");
            foreach (int s in arr)
            {
                Console.Write(s + " ");
            }
            Array.Sort(arr);
            Console.WriteLine("\narr after sort = ");
            foreach (int s in arr)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            sqr(ref num);
            Console.WriteLine("num sqr is " + num);
        }


        public static void sqr(ref int i)
        {
            i = i * i;

        }

    }
    class Myclass
    {
        public static readonly int foo = 90;
        public static int d, e, f;
        static Myclass()
        {
            Console.WriteLine("Static constructor of Myclass");
            foo = 100; // works for static readonly
            //Console.WriteLine("d = " + d + ", e= " + e + ", f= " + f);
        }
        public Myclass()
        {
            //foo = 6;
            //foo = 100; // error for static readonly
            //int a = 4;
            Console.WriteLine("d = " + d + ", e= " + e + ", f= " + f);
        }
    }
}
