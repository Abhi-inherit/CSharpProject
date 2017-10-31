using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAddressSystem
{
    class address
    {
        string[] street;
        string[] city;
        string[] state;
        string[] postalCode;
        string[] country;

        public address() 
        {
        }

        public address(int l)
        {
            street = new string[l];
            city = new string[l];
            state = new string[l];
            postalCode = new string[l];
            country = new string[l];
        }

        public void AddressDetails(int i)
        {
                Console.Write("Enter Street:");
                street[i] = Console.ReadLine();
                Console.Write("Enter city:");
                city[i] = Console.ReadLine();
                Console.Write("Enter state:");
                state[i] = Console.ReadLine();
                Console.Write("Enter Postal code:");
                postalCode[i] = Console.ReadLine();
                Console.Write("Enter country:");
                country[i] = Console.ReadLine();
        }

        public void AddressDisplay(int i)
        {
            Console.WriteLine("Street : {0}", street[i]);
            Console.WriteLine("City : {0}", city[i]);
            Console.WriteLine("State : {0}", state[i]);
            Console.WriteLine("Postal code : {0}", postalCode[i]);
            Console.WriteLine("Country : {0}", country[i]);
        }
    }
}
