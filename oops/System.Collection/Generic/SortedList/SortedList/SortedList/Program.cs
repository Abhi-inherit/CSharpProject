using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> oenWith = new SortedList<int, string>();
            Console.WriteLine("Enter 10 names");

            for (int index = 0; index < 10; index++ )
            { 
                oenWith.Add(index,Convert.ToString(Console.ReadLine()));
           
            }

            Console.WriteLine();

            foreach(KeyValuePair<int, string> pair in oenWith)
            {
                Console.WriteLine("KEY = {0}", pair);
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Enter key value here");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name for the entered key");
            string valueName = Convert.ToString(Console.ReadLine());
            oenWith[key] = valueName;
            Console.WriteLine();

            foreach(KeyValuePair<int, string> pair in oenWith)
            {
                Console.WriteLine("Key {0}",pair);
            }
            Console.ReadLine();
            
         }
    }
}
