using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            try
            {
                Console.WriteLine("This line is executed to throw a message saying division by zero not possible in given case.");
                y = 100 / x;
            }
            
            catch (Exception Ex)
            {
                Console.WriteLine("Exception occured:{0}",Ex.ToString());
                Console.ReadLine();
            }
            Console.WriteLine("Result is {0}:", y);
            Console.ReadLine();
        }
    }
}
