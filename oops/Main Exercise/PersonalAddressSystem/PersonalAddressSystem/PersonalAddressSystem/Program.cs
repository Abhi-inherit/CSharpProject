using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAddressSystem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int limit = 0;
            Console.WriteLine("PERSONAL INFORMATION");
            Console.WriteLine("Enter 1 for student registeration.");
            Console.WriteLine("Enter 2 for professor registeration.");
            Console.Write("Enter: ");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (type == 1)
            {
                Console.WriteLine("Enter total number of Students for exam registering:");
                limit = Convert.ToInt32(Console.ReadLine());
                Student std = new Student(limit);
                std.StudentDetails();
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("___DETAILS FOR PRINTING___");
                std.Display();
                Console.ReadLine();
               
            }
            else if (type == 2)
            {
                Console.WriteLine("Enter total number of professors for salary registering:");
                limit = Convert.ToInt32(Console.ReadLine());
                Professor prf = new Professor(limit);
                prf.ProffessorDetails();
                Console.Clear();
                Console.WriteLine("_______________DETAILS FOR PRINTING_______________");
                prf.Display();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You have entered a wrong input.");
            }

            Console.ReadLine();
        }
    }
}
