using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithamaticEception
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            try 
            {
                int div = 100/number;
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine("{0}", ae);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e);
            }
            Console.ReadLine();
        }
    }
}
