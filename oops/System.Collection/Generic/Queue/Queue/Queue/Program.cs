using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> StudentsName = new Queue<string>();
            Console.WriteLine("Enter 5 students name.");
            try 
            {
                for (int index = 0; index < 5; index++ )
                {
                    StudentsName.Enqueue(Console.ReadLine());                
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Values from Queues");
            Console.WriteLine();
            PrintQueue(StudentsName);
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("\nDequeing '{0}'", StudentsName.Dequeue());
            Console.WriteLine("***********************");
            Console.WriteLine("Values from Queue after removing an item");
            Console.WriteLine();
            PrintQueue(StudentsName);
            Console.ReadLine();
            StudentsName.Clear();
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^");
            Console.ReadLine();
        }

        private static void PrintQueue(Queue<string> StudentsName)
        {
            try 
            {
                foreach(string n in StudentsName)
                {
                    Console.WriteLine(n);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
