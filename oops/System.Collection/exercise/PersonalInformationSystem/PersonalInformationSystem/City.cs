using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationSystem
{
    class City: Country
    {
        //public int cityID { get; set; }
        public string cityName { get; set; }

        public void CityDetailsAdd()
        {
            //Console.Write("Enter city ID:");
            //cityID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter City name:");
            cityName = Console.ReadLine();
            CountryDetailsAdd();
        }

        public void CityDispaly()
        {
           // Console.WriteLine("-----Country Details-----");
            Console.WriteLine(" City Name     : {0}", cityName);
        }

        public bool CitySorting(string city)
        { 
            if (city == cityName)
            {
                return true;
            }
            else

            return false;
        }
    }   
}
