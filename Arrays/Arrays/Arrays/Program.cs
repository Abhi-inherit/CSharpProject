using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray;
            jaggedArray = new int[2][];
            jaggedArray[0] = new int[4];
            jaggedArray[1] = new int[5];
            

            jaggedArray[0][0] = 2;
            jaggedArray[0][1] = 5;
            jaggedArray[0][2] = 8;
            jaggedArray[0][3] = 7;

            jaggedArray[1][0] = 2;
            jaggedArray[1][1] = 5;
            jaggedArray[1][2] = 8;
            jaggedArray[1][3] = 7;
            jaggedArray[1][4] = 7;

            Console.WriteLine(jaggedArray[0][1]);
            Console.ReadLine();




           int[,] matrixTest = 
            {
            {4,5,6,7},
            {0,2,2,3}
            };

            int[,] matrix = {
                                    {0,3,4,7,8,9},
                                    {5,6,7,3,4,2},
                                    {6,5,6,1,2,8},
                                    {4,4,2,1,7,8},
                                    {5,6,3,4,3,1},
                                    {5,6,3,4,3,1}
                               };

            //Console.WriteLine(matrix.GetLength(0));
            //Console.ReadLine();

            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row ++ )
            {
                for (int col = 0; col < matrix.GetLength(0) - 1; col++ ) 
                {
                    long sum = matrix[row, col] + 
                               matrix[row, col + 1] + 
                               matrix[row + 1, col] + 
                               matrix[row + 1, col + 1];
                }
            }
            Console.WriteLine("The best platform is:");
            Console.WriteLine(" {0} {1}",
            matrix[bestRow, bestCol], 
            matrix[bestRow, bestCol + 1]);

            Console.WriteLine(" {0} {1}",
            matrix[bestRow + 1, bestCol],
            matrix[bestRow + 1, bestCol + 1]);

            Console.WriteLine("The maximal sum is: {0}", bestSum);
            Console.ReadLine();
        }
    }
}
