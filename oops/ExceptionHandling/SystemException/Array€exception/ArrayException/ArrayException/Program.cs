using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayException
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
            string[] array1 = {"Cat","Dog","Goat"};
            object[] array2 = array1;
            array2[0] = "Dinosour";
            
            }
            catch(ArrayTypeMismatchException am)
            {
                Console.WriteLine(am.Message);
            }
            Console.ReadLine();
        }
    }
}
