// Problem 2. Maximal sum
// Write a program that reads a rectangular matrix of size N x M
// and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Linq;

    class MaximalSum
    {
        static void Main()
        {
            Console.Write("Enter rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter cols: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            initalMatrix(matrix);

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            int size = 3;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] +
                                 matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] +
                                 matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The best platform 3 x 3 is:  ");
            for (int row = bestRow; row < bestRow + size; row++)
            {
                for (int col = bestCol; col < bestCol + size; col++)
                {
                    Console.Write(" {0} ".PadLeft(3), matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        
        static void initalMatrix(int[,] matrix)
        {
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++, counter++)
                {
                    matrix[row, col] += counter;
                    Console.Write( " " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }

