using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerived mc = new MyDerived();
           // mc.MyMethod();
            Console.WriteLine("The value of x is been increased to 10. So total will be 100 + 10 = {0}", mc.Getx);
            Console.WriteLine("The value of y is been increased to 10. So total will be 150 + 10 = {0}", mc.GetY);
            Console.ReadLine();
        }
    }
}
