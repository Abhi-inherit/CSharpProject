using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationSystem
{
    class Country
    {
       // public int countryID { get; set; }
        public string countryName { get; set; }

        public void CountryDetailsAdd()
        {
            //Console.Write("Enter the Country Id:");
            //countryID = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter the Country Name:");
            countryName = (Console.ReadLine());
        }

        public void CountryDispaly()
        {
            //Console.WriteLine("-----Country Details-----");
            Console.WriteLine(" Country Name   : {0}", countryName);
        }
    }
    
}
