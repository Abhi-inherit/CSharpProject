using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> dinosorous = new List<string>();
            Console.WriteLine("\nCapacity: {0}",dinosorous.Capacity);
            dinosorous.Add("Tyrannosours");
            dinosorous.Add("Sipronosorous");
            dinosorous.Add("Memenciraus");
            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}",dinosorous.Capacity);
            dinosorous.Add("Grigaritorus");
            Console.WriteLine("Capacity: {0}",dinosorous.Capacity);
            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);
            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);

            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);

            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);

            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);

            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);

            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);

            dinosorous.Add("Composognatus");
            Console.WriteLine("Capacity: {0}", dinosorous.Capacity);
           
            Console.WriteLine("\n");
            foreach(string dinosor in dinosorous)
            {
                Console.WriteLine(dinosor);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Capacity: {0}",dinosorous.Capacity);
            Console.WriteLine("Count: {0}",dinosorous.Count);

            Console.WriteLine();
            Console.WriteLine("\n Contains(\"Tyrannosours\"): {0}",dinosorous.Contains("Tyrannosours"));
            Console.WriteLine("\n Inser to the position (2:\"Sipronosorous\")");
            dinosorous.Insert(2,"Triyalosorour");

            Console.WriteLine();
            foreach(string dinosor in dinosorous)
            {
                Console.WriteLine(dinosor);
            }
            Console.WriteLine();

            dinosorous.Clear();

            Console.WriteLine("\nClear();");
            Console.WriteLine("Capacity: {0}",dinosorous.Capacity);
            Console.WriteLine("Count: {0}", dinosorous.Count);
            Console.ReadLine();
        }
    }
}
