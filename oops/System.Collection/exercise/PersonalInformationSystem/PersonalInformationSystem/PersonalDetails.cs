using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationSystem
{
    class PersonalDetails:Address
    {
     
        public string firstName{get;set;}
        //public string lastName{get;set;}
        //public int age{get;set;}
        //public string houseAddress{get;set;}
        //public string workAddress {get;set;}
        //public Address Address { get; set; }

        public PersonalDetails PersonlDetailsAdd()
        {

           PersonalDetails perDetail = new PersonalDetails();
                Console.Write("Enter first name:");
                perDetail.firstName = Console.ReadLine();
                //Console.Write("Enter last name:");
                //perDetail.lastName = Console.ReadLine();
                //Console.Write("Enter age:");
                //perDetail.age = Convert.ToInt32(Console.ReadLine());
                //Console.Write("Enter home address:");
                //perDetail.houseAddress = Console.ReadLine();
                //Console.Write("Enter work address:");
                //perDetail.workAddress = Console.ReadLine();
                perDetail.AddressDetailsAdd();
                return perDetail;
        }

        public void PersonDisplay()
        {
            Console.WriteLine("-----Person Details-----");
            Console.WriteLine(" First Name : {0}", firstName);
            //Console.WriteLine(" Last Name  : {0}", lastName);
            //Console.WriteLine(" Age        : {0}", age);
            //Console.WriteLine(" House address: {0}", houseAddress);
            //Console.WriteLine(" Work address : {0}", workAddress);

        }

        public bool PersonSorting(string name)
        {
            if (name == firstName)
            {
                return true;
            }
            else

                return false;
        }


    }
}
