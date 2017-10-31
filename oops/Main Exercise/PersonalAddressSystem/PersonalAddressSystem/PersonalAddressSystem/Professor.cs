using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAddressSystem
{
    class Professor : Person
    {
        int[] salary;
        int limit;

        public Professor()
        { 
        
        }

        public Professor(int l): base(l)
        {
            Person per = new Person(l);
            salary = new int[l];
            limit = l;
        }

        public void ProffessorDetails()
        {

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Serial Number: {0}", i + 1);
                Console.Write("Enter salary:");
                salary[i] = Convert.ToInt32(Console.ReadLine());
                PersonDetails(i);
            }
        }
        public void Display()
        {
            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Serial Number: {0}", i + 1);
                Console.WriteLine("Salary: {0}", salary[i]);
                PersonDisplay(i);
            }
        }
    }
}
