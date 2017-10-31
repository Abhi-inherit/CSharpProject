using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Dict = new Dictionary<string, int>();

            Dict.Add("HP",1);
            Dict.Add("Dell",2);
            Dict.Add("Compaq",3);
            Dict.Add("Acer", 4);

            Console.WriteLine("---------------------");
            if (Dict.ContainsKey("xcv"))
            {
                Console.WriteLine("Value found");
            }
            else
            {
                Console.WriteLine("Value not found");            
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");

            try
            {
                Dict.Add("txt", 3);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with key = \"txt\" already exists.");
            }

            Console.WriteLine("-----------------------");
            foreach (KeyValuePair<String, int> Pair in Dict)
            {
                Console.WriteLine("Your values: {0}{1}",Pair.Value,Pair.Key);            
            }

            Console.WriteLine("-----------Total function-----------");


            var dict = new Dictionary<string, decimal>();

            dict.Add("A", 1.0m); // This value will be skipped
            dict.Add("B", 2.0m);
            dict.Add("C", 1.0m);
            dict.Add("D", 3.0m);

            var total = dict.Sum(v => v.Value);

            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
