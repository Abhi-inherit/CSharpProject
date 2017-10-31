using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAddressSystem
{
    class Student:Person
    {
        int[] rollNumber;
        int[] avgMark;
        int limit;

        public Student()
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        }
        public Student(int l):base(l)
        {
           Person per = new Person(l);
            rollNumber = new int[l];
            avgMark = new int[l];
            limit = l;
        }

      public void StudentDetails()
        {

            for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Serial Number: {0}",i + 1);
                    Console.Write("Enter the roll number:");
                    rollNumber[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter average mark:");
                    avgMark[i] = Convert.ToInt32(Console.ReadLine());
                    PersonDetails(i);
                    
                   
                }
        }
        public void Display()
        {
            for (int i = 0; i < limit; i++)
              {
                  Console.WriteLine("\n");
                  Console.WriteLine("Serial Number: {0}", i + 1);
                  Console.WriteLine("Roll number: {0}", rollNumber[i]);
                  Console.WriteLine("Aerage Mark: {0}", avgMark[i]);
                  if (avgMark[i] < 40)
                  {
                      Console.WriteLine("NOT ELIGIBLE FOR EXAM.");
                  }
                  else 
                  {
                      Console.WriteLine("ELIGIBLE FOR EXAM.");
                  }
                  PersonDisplay(i);
                  
              }
        }

        
    }
}
