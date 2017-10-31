using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class property
    {
        public string propertyType;
        public int bedrooms;
       
        internal void displayDetails()
        {

            Console.WriteLine("DAMAC PROPERTIES\r");
            Console.WriteLine("Properties inventory details\r");
            Console.Write("Property type: ");
            Console.WriteLine(propertyType);
            Console.Write("Bedroom: ");
            Console.WriteLine(bedrooms);
            Console.ReadLine();
        }
    }
}
