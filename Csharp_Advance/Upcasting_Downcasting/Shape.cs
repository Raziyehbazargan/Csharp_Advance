using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Advance.Inheritance;

namespace Csharp_Advance.Upcasting_Downcasting
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public static implicit operator Shape(Inheritance.Text v)
        {
            throw new NotImplementedException();
        }
    }
}
