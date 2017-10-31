using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    class Program
    {
        public static void Main(string[] args)
        {
            square sq = new square();
            DisplayDetails(sq);
            Console.WriteLine("----------");
            Rectangle re = new Rectangle();
            DisplayRectangle(re);
            Console.ReadKey();

        }

        static void DisplayDetails(square S)
        {
            Console.WriteLine("Square Characteristic ");
            Console.WriteLine("Name: {0}",S.Name);
            Console.WriteLine("Descriotion: {0}",S.Describe());
            Console.ReadLine();

        }
        static void DisplayRectangle(Rectangle S)
        {
            Console.WriteLine("Rectangle Characteristic");
            Console.WriteLine("Name: {0}",S.Name);
            Console.WriteLine("Description: {0}",S.Describe());
            Console.ReadLine();
        }
    }
}
