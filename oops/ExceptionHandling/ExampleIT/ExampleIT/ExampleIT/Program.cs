using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Program reThrow = new Program();
            try
            { 
            reThrow.Foo();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        } 
        
        public void Par()
            {
                try
                {
                    int x = 8;
                    int y = 0;
                    int xy = x/y;
                }
                catch(Exception)
                {
                   Console.WriteLine("Par"); 
                    throw;
                }
            }

        public void Bar()
        {
            try 
            {
                Par();
            }
            catch(Exception)
            {
                Console.WriteLine("Bar");
                throw;  
            }
        }

        public void Foo()
        {
            try
            {
                Bar();
            }
            catch(Exception)
            {
                Console.WriteLine("foo");
                throw;
            }
        }
    }
}
