// Problem 6.* Matrix class
// Write a class Matrix, to hold a matrix of integers. Overload the operators for adding,
// subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;
class MatrixClass
{
    static void Main()
    {
        Console.Write("Rows mastrix 1=");
        int rows1 = int.Parse(Console.ReadLine());
        Console.Write("Cols mastrix 1=");
        int cols1 = int.Parse(Console.ReadLine());
        Console.Write("Rows mastrix 2=");
        int rows2 = int.Parse(Console.ReadLine());
        Console.Write("Cols mastrix 2=");
        int cols2 = int.Parse(Console.ReadLine());
        Matrix matrix1 = new Matrix(rows1, cols1);
        Console.WriteLine("Enter elements in matrix 1:");
        for (int row = 0; row < rows1; row++)
        {
            for (int col = 0; col < cols1; col++)
            {
                matrix1[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Matrix matrix2 = new Matrix(rows2, cols2);
        Console.WriteLine("Enter elements in matrix 2:");
        for (int row = 0; row < rows2; row++)
        {
            for (int col = 0; col < cols2; col++)
            {
                matrix2[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Matrix sum = matrix1 + matrix2;
        Console.WriteLine(sum.ToString());
        Matrix min = matrix1 - matrix2;
        Console.WriteLine(min.ToString());
        Matrix multi = matrix1 * matrix2;
        Console.WriteLine(multi.ToString());
    }


  
}