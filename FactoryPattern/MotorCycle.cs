using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MotorCycle : IVehicle // // I create the MotorCycle class below that is public and will conform to IVehicle:
    {
        public MotorCycle() //I created a public class for MotorCycle.
        {
        }
            public void Drive()
            {
                Console.WriteLine("The Motorcycle is too loud!");
                Console.WriteLine("roooaaarrrriiiinng all night and day");
            }
        }
    }

