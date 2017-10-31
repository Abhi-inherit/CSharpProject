using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Al = new ArrayList();
            Al.Add(55);
            Al.Add(45);
            Al.Add(90);
            Al.Add(80);
            Al.Add(70);
            Al.Add(50);
            Al.Add(20);

            Console.WriteLine("Original Conetents");
            foreach (int i in Al)
            {
                Console.Write(i + " ");
                Console.WriteLine("\n");
                
            }
            Console.ReadLine();

            Al.Sort();
        }
    }
}
