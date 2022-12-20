using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory // Create a static VehicleFactory class:---DONE
    {
        public static IVehicle GetVehicle(int wheelCount)
            //Add a GetVehicle method that will return an IVehicle based on the amount of tires it’s given as a parameter: ---DONE
            //Make the method static----DONE
            //A return type of IVehicle----DONE
            //1 string parameter----DONE

        {
            switch (wheelCount)
            {
                case 2:
                    return new MotorCycle();
                case 3:
                    return new ThreeWheeler();
                case 4:
                    return new Car();
                default:
                    return new Car();

            }
        }
    }
}
