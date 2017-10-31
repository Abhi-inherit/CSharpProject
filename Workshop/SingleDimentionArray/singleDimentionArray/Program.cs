using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDArray 
{ 
    class CSDArray 
    {
        public static void Main()
        {
            //int[] array = new int[1];
            //array[0] = 2;
            //Console.WriteLine(array[0]);
            //Console.ReadLine();
            int[, , ,] array2D = new int[, , ,] 
            { 
                {{{ 11, 66, 14, 15 },{55,89,78,85},{12,89,78,85},{12,89,78,85}}}, 
                {{{ 3, 4, 5, 16},{22,89,78,85},{12,89,78,85},{12,89,78,85}}}, 
                {{{ 5, 6, 7, 14 },{32,89,78,85},{12,89,78,85},{12,89,78,85}}}, 
                {{{ 7, 8, 9, 18 },{12,89,78,85},{12,89,78,85},{12,89,78,85}}}
            };

            int[, ,] array3D = new int[,,] 
            { { { 1, 2, 3 }, { 4, 5, 6 } }, 
              { { 7, 8, 9 }, { 10, 11, 12 } } 
            };

            System.Console.WriteLine(array3D[1, 1, 1]);

            Console.WriteLine(array2D[0, 0, 1, 0]);
            Console.WriteLine(array2D[0, 0, 0, 1]);
            Console.WriteLine(array2D[0, 0, 0, 2]);
            Console.WriteLine(array2D[0, 0, 0, 3]);
            Console.WriteLine(array2D[1, 0, 0, 0]);
            Console.WriteLine(array2D[2, 0, 0, 0]);
            Console.ReadLine();
        }
    }
}