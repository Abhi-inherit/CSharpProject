using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            Console.WriteLine("Enter days in a week:");
            for (int i = 0; i < 7; i++ )
            {
                myStack.Push(Console.ReadLine());
               

            } 
            Console.WriteLine("My Stack");
            Console.WriteLine("Count: {0}",myStack.Count);
            Console.WriteLine("Values:");
            PrintStackValues(myStack);

            Console.WriteLine("\n");    
            Console.WriteLine("---Elements poped from top of the stack---");
            Console.WriteLine(myStack.Pop());

            Console.WriteLine("\n");
            Console.WriteLine("---Element now at the top");
            Console.WriteLine(myStack.Peek());
            

            Console.WriteLine("\n");
            Console.WriteLine("---Element count---");
            Console.WriteLine(myStack.Count);

            Console.WriteLine("\n");
            Console.WriteLine("Stack is clear");
            myStack.Clear();
            Console.ReadLine(); 
        }

        public static void PrintStackValues(Stack myStack)
        { 
            foreach (object values in myStack)
            {
                Console.WriteLine("My Stack Values: {0}",values);
                Console.WriteLine("\n");
            }
        }
    }
}
