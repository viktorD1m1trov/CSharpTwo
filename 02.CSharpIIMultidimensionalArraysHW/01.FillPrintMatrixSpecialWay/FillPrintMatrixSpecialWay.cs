//  1.a.Write a program that fills and prints a matrix of size (n, n)
//  as shown below: (examples for n = 4)


using System;

class FillPrintMatrixSpecialWay
{
    static void Main()
    {
        Console.WriteLine("Input dimension of the maatrix:");
        int dimensionMatrix = int.Parse(Console.ReadLine());
        int[,] arrayInt = new int[dimensionMatrix, dimensionMatrix];

        for (int row = 0; row < arrayInt.GetLength(0); row++)
        {
            for (int col = 1; col <= arrayInt.Length; col += dimensionMatrix)
            {
                Console.Write("{0,3}", (row + col));
               
            }
            Console.WriteLine();
        }
    }
}

