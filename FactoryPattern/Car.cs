using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle  // I create the Car class below that is public and will conform to IVehicle:

    {
        public Car() // I created a public class for Car.
        {
        }

        public void Drive() // I created a public class for Car.
        {
            Console.WriteLine("The Car is driving! Woo Wee Buddy");
            
        }
    }
}
