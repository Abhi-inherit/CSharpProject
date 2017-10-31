using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class circle
    {
        circleCalculation crCal = new circleCalculation();
        public double di;
        public double ci;
        public double ar;

        public void CircleFunction() 
        {
            //circleCalculation crCal = new circleCalculation();
            Console.WriteLine("Circle Details");
            Console.Write("Enter the Circle radius:");
            crCal.radius = double.Parse(Console.ReadLine());
        }
        public void RadiusFunction()
        {
            Console.WriteLine("Radius = {0}",crCal.radius);
        }
        public void DiameterFunction()
        {
            di = (crCal.radius + crCal.radius);
            Console.WriteLine("Diameter = {0}", di);
            
        }
        public void Circumference()
        {
            ci = di * Math.PI;
            Console.WriteLine("Circumference = {0}", ci);
        }
        public void Area()
        {
            ar = crCal.radius * crCal.radius * Math.PI;
            Console.WriteLine("Area = {0}", ar);
        }
    }
}
