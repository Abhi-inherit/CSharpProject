using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationSystem
{
    class Address: City
    {
        public string eMail { get; set; } 
        //public string phoneNumber { get; set; }
        //public int roomNumber { get; set; }
        //public string building { get; set; }
        //public string street { get; set; }
        
       
        

        public void AddressDetailsAdd()
        {   
            Console.Write("Enter E-mail:");
            eMail = Console.ReadLine();
            //Console.Write("Enter phone number:");
            //phoneNumber = Console.ReadLine();
            //Console.Write("Enter room number:");
            //roomNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter building name:");
            //building = Console.ReadLine();
            //Console.Write("Enter street name:");
            //street = Console.ReadLine();
            CityDetailsAdd();
        }

        public void AddressDisplay()
        {
           // Console.WriteLine("-----Address Details-----");
            Console.WriteLine(" E-mail Id     : {0}", eMail);
            //Console.WriteLine(" Phone Number  : {0}", phoneNumber);
            //Console.WriteLine(" Room Number   : {0}", roomNumber);
            //Console.WriteLine(" Building Name : {0}", building);
            //Console.WriteLine(" Street Name   : {0}", street);
        }
    }
}
