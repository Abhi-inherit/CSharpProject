using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Total number of peoples needed to be entered.");
            Console.Write(":");
            int totalNumber = Convert.ToInt32(Console.ReadLine());
           
            List<PersonalDetails> perDetail = new List<PersonalDetails>();

            for (int x = 0; x < totalNumber; x++)
            {
                PersonalDetails Obj = new PersonalDetails();
                perDetail.Add(Obj.PersonlDetailsAdd());
                Console.WriteLine("");
            }

            for (int i = 0; i < totalNumber; i++)
            {
                perDetail[i].PersonDisplay();
                perDetail[i].AddressDisplay();
                perDetail[i].CityDispaly();
                perDetail[i].CountryDispaly();
                Console.WriteLine("");
            }
            Console.ReadLine();

            Console.WriteLine("1. Details of Country Sort By City\n2. Country wise listing \n3. Details of Country Sort order by city & firstName");
            Console.WriteLine("Enter your Choice");
            int Choice = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalNumber; i++ ) 
            {
                if(Choice==1)
                {
                    perDetail.OrderBy(name1 => name1.cityName).ToList();
                    Console.WriteLine(perDetail[i].firstName);
                }
                else if (Choice == 2)
                {
                    perDetail.GroupBy(name1 => name1.countryName).ToList();
                    perDetail[i].PersonDisplay();

                }
                else
                { }
            }
            Console.ReadLine();

            Console.Write("Enter the city name for listing people registered in that patricular city:");
            string city = Console.ReadLine();

            for (int i = 0; i < totalNumber; i++)
            {
                if (perDetail[i].CitySorting(city) == true)
                { 
                perDetail[i].PersonDisplay();
                perDetail[i].AddressDisplay();
                perDetail[i].CityDispaly();
                perDetail[i].CountryDispaly();
                Console.WriteLine("");
                }
            }
            Console.ReadLine();

            Console.Write("Enter the city name you want to search in:");
            string cS = Console.ReadLine();
            Console.Write("Enter the person name you want to get deatil in above entered city {0}:",cS);
            string name = Console.ReadLine();

            for (int i = 0; i < totalNumber; i++)
            {
                if (perDetail[i].CitySorting(cS) == true)
                {
                    if (perDetail[i].PersonSorting(name) == true)
                    {
                        perDetail[i].PersonDisplay();
                        perDetail[i].AddressDisplay();
                        perDetail[i].CityDispaly();
                        perDetail[i].CountryDispaly();
                        Console.WriteLine("");
                    }
                }
            }
            Console.ReadLine();
        }

    }
}
