using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total number of students for the accademic year 2017: ");
            int Limit = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            string[] name = new string[Limit];
            int[] Maths = new int[Limit];
            int[] Physics = new int[Limit];
            int[] Chemistry = new int[Limit];
            int[] Total = new int[Limit];
            float[] x = new float[Limit];
            float[] r = new float[Limit];
            string[] Status = new string[Limit];

            //double [] Percentage=new double[Limit];
            //Console.WriteLine(Limit);
            //Console.ReadLine();
            for (int i = 0; i < Limit; i++) 
            {
                //Console.WriteLine("Enter the {0} Students Details",i+1);
                Console.Write("NAME : ");
                name[i] = Console.ReadLine();
                //Console.WriteLine(name[i]);
                Console.Write("Mark Of Maths : ");
                Maths[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mark Of Physics : ");
                Physics[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mark Of Chemistry : ");
                Chemistry[i] = Convert.ToInt32(Console.ReadLine());

                if (Maths[i] < 15 || Physics[i] < 15 || Chemistry[i] < 15)
                {
                    Console.WriteLine("Failed in the accademic year 2017");
                    Console.Write("\n");
                    Console.ReadLine();
                    Status[i] = "Failed";
                }
                else 
                { 
                x[i] = (Maths[i] + Physics[i] + Chemistry[i]);
                float t = 300;
                r[i] = (x[i] / t) * 100; 
                Console.WriteLine("{0} has passed the academic year 2017 with a total percentage of {1}", name[i], r[i]);
                Console.Write("\n");
                Console.ReadLine();
                Status[i] = "Passed";
                }
                
            }
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("                   STUDENTS DETAILS                       ");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("NAME\tMaths  Physics  Chemistry  Total  Percentage \tStatus \n");
                Console.ReadLine();
                //Console.WriteLine("ssss{0}",Limit);
                for (int i = 0; i < Limit; i++)
                {
                    Console.WriteLine(name[i] + "\t" + Maths[i] + "      " + Physics[i] + "        " + Chemistry[i] + "       " + x[i] + "      " + r[i] + "%" + "\t" + Status[i]);
                    Console.Write("\n");
                    Console.ReadLine();
                }
                Console.ReadLine();
        }

    }
}
