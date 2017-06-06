using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignArea
{
    class Shape
    {
        readonly int _height;
        int _width;

        public Shape(int w)
        {
            _height = 20;
            _width = w;
        }

        public int Height
        {
            get
            {
                return _height;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int area()
        {
            return Width * Height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape(25);
            Console.WriteLine("Area of the shape is {0}", s.area());
        }
    }
}
