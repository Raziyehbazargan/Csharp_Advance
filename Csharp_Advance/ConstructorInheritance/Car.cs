using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Advance.ConstructorInheritance
{
    public class Car : Vehicle
    {
        public Car(String registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being Initialized. {0}", registrationNumber);
        }
    }
}
