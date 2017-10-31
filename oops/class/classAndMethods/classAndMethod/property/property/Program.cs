using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property
{
    class Program
    {
       

        static void Main(string[] args)
        {
            property prt = new property();
            prt.propertyType = "Limited Edition";
            prt.bedrooms = 4; 
            prt.displayDetails();

        }
    }
}
