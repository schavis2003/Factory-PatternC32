using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle  // I create the ThreeWheeler class below that is public and will conform to IVehicle:

    {
        public ThreeWheeler() //I created a public class for ThreeWheeler.
        {
            Console.WriteLine("Let have some fun!");
        }
        public void Drive() //I created a public class for Car.
        {
            Console.WriteLine("Let's get going baby");
        }
    }
}


