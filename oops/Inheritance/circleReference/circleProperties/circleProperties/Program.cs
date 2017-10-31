using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleProperties
{
    class Program
    {
        
            static void Main(string[] args)
        {
            var round = new Circle();
            round.Radius = 40;

            Console.WriteLine("Circle Characteristics");
            Console.WriteLine("Side:     {0}", round.Radius);
            Console.WriteLine("Diameter: {0}", round.Diameter);
            Console.WriteLine("Circumference: {0}", round.Circumference);
            Console.WriteLine("Area:     {0}", round.Area);

            var ball = new Sphere();
            ball.Radius = 50;

            Console.WriteLine("\nSphere Characteristics");
            Console.WriteLine("Side:     {0}", ball.Radius);
            Console.WriteLine("Diameter: {0}", ball.Diameter);
            Console.WriteLine("Circumference: {0}", ball.Circumference);
            Console.WriteLine("Area:     {0}", ball.Area);
            Console.ReadLine();
        }
     }
}

