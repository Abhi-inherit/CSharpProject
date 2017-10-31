using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queue1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            Console.WriteLine("myQ");
            Console.WriteLine("Count: {0}",myQ.Count);
            Console.WriteLine("Values:");
            PrintQ(myQ);
            Console.ReadLine();

        }

        public static void PrintQ(Queue valueOfQueue)
        { 
            foreach(object Qvalues in valueOfQueue)
            {
                Console.Write(" {0}",Qvalues);
                Console.WriteLine();
            }
        }

    }
}
