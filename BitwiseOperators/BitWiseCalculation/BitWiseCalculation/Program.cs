using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWiseCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 3; // 0000 0011 = 3 
            byte b = 5; // 0000 0101 = 5 
            Console.WriteLine(a | b);
            Console.ReadLine();
        }
    }
}
