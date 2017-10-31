using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            Console.WriteLine("Enter 5 students name here:");
            Console.WriteLine();
            for (int i=0; i<5; i++)
            {
                names.Push(Console.ReadLine());
            }

            Console.WriteLine("\n");
            Console.Write("Printing the stack items\n");
            printStack(names);


            Console.WriteLine("\n");
            Console.WriteLine("Pop item from the stack:", names.Pop());
            printStack(names);

            Console.WriteLine("\n");
            Console.WriteLine("Elements in the stack:");
            Console.WriteLine(names.Count());
            Console.ReadLine();
             
        }

        public static void printStack(Stack<string> s)
        {
            try
            {
                foreach (string namesFrom in s)
                {
                    Console.WriteLine(namesFrom);
                    //Console.WriteLine();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    
    }

}
