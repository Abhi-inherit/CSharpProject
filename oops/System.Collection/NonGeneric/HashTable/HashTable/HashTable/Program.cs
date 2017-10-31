using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"One");
            ht.Add(2,"Two");
            ht.Add(3,"Three");
            ht.Add(4,"Four");
            foreach(DictionaryEntry de in ht)
            {
                int key = (int)de.Key;
                String value = de.Value.ToString();
                Console.WriteLine(key + " " + value);
            }
            Console.ReadLine();
        }
    }
}
