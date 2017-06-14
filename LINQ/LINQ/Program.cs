using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Car
    {
        public string Brand { get; set; }
        public double speed { get; set; }
        public string color { get; set; }

        public static IEnumerable<Car> getDetails(List<Car> list)
        {
            IEnumerable<Car> subset = from g in list where g.speed > 50 select g;
            
            return subset;
        }

        public override string ToString()
        {
            return string.Format("Car Brand: {0}\nColor: {1}\nSpeed: {2}m/hr", Brand, color, speed);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>()
            {
                new Car{Brand="BMW", color="Blue", speed=200},
                new Car {Brand="Audi", color="Black", speed=250},
                new Car{Brand="Lamborghini", color="Yellow", speed=300}
            };
            IEnumerable<Car> list = Car.getDetails(carList);

            foreach (Car c in list) {
                Console.WriteLine(c);
            }
        }
    }
}
