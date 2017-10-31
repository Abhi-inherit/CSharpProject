using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrgumentException
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            string s = "Something";
            try
            {
                int i = s.CompareTo(my);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
