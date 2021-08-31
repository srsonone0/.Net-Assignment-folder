using System;
class matrixMul
{
    public static void Main()
    {
        int[,] mat1 = new int[2, 2];
        int[,] mat2 = new int[2, 2];
        int[,] multiplication = new int[2, 2];
        int i, j;
        Console.WriteLine("Enter the elements of the matrix1: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                mat1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Entered elements of the matrix1: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("{0} ", mat1[i, j]);
            }
            Console.Write("\n");
        }

        Console.WriteLine("Enter the elements of the matrix2: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                mat2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Entered elements of the matrix2: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("{0} ", mat2[i, j]);
            }
            Console.Write("\n");
        }

        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                multiplication[i, j] = mat1[i, j] * mat2[i, j];
            }
        }

        Console.WriteLine("Multiplication of the matrix1 and matrix2: ");
        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write("{0} ", multiplication[i, j]);
            }
            Console.Write("\n");
        }
    }
}


