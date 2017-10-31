using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 98, b = 0;
            double result = 0;

            try 
            {
                result = SafeDivision(a, b);
                Console.WriteLine("the result for {0} divided by {1} equals {2}", a, b, result);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Compilation error found: DETAILS-> {0}", ex);
                Console.ReadLine();
            }
        }

        static double SafeDivision(double x, double y)
        {
            if(y == 0)
                throw new Exception("wrong entry of variables");
            double reuslt = x/y;
            return reuslt;
        }
    }
}
