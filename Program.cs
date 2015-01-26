using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Citröen", "C1");
            Console.WriteLine(car);
            Truck truck = new Truck("Scania", "Something", 1000000);
            Console.WriteLine(truck);
            Truck awesomeTruck = new Truck("volvo", "Something else", 1000, new DieselEngine());
            Console.WriteLine(awesomeTruck);

        }
    }
}
