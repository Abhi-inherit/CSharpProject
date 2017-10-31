using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {

            circle ci = new circle();
            ci.CircleFunction();
            ci.RadiusFunction();
            ci.DiameterFunction();
            ci.Circumference();
            ci.Area();
            Console.ReadLine();

        }
    }
}
