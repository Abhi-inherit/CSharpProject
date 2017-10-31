using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAddressSystem
{
    class Person:address
    {
        string[] name;
        int[] phoneNumber;
        string[] eMail;

        public Person()
                {
                    // TODO: Complete member initialization
                }
        public Person(int k):base(k)
        {
           address add = new address(k);
            name = new string[k];
            phoneNumber = new int[k];
            eMail = new string[k];
        }
        public void PersonDetails(int i)
        {

          
                Console.Write("Enter the Name:");
                name[i] =Console.ReadLine();
                Console.Write("Please enter Phone number:");
                phoneNumber[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the E Mail:");
                eMail[i] = Console.ReadLine();
                AddressDetails(i);
           
        }
        public void PersonDisplay(int i)
        {
            Console.WriteLine("Name : {0}", name[i]);
            Console.WriteLine("Phone number : {0}", phoneNumber[i]);
            Console.WriteLine("E mail : {0}", eMail[i]);
            AddressDisplay(i);
        }
    }
}
