using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList StudnetsData = new ArrayList();
            Console.WriteLine("Enter Your Students Name Here:");
            for (int index = 0; index < 5; index++)
            {
                StudnetsData.Add(Console.ReadLine());
            }
            Console.WriteLine("Display The Data");
            PrintValues(StudnetsData);
            StudnetsData.Reverse();
            Console.WriteLine("Data In Reverse Order");
            PrintValues(StudnetsData);
            Console.WriteLine("Clear The Array List");
            StudnetsData.Clear();
            PrintValues(StudnetsData);
            Console.ReadLine();
        }
        void PrintValues(ArrayList listStudens)
        {
            foreach (object fromarraylist in listStudens)
            {
                Console.WriteLine("   {0}", fromarraylist);
                Console.WriteLine();
            }
        }
    }
}
