//  1.c.Write a program that fills and prints a matrix of size (n, n)
//  as shown below: (examples for n = 4)


using System;

class FillPrintMatrixSpecialWay
{
    static void PrintArrayInt(int[,] arrInt)
    {
        for (int i = 0; i < arrInt.GetLength(0); i++)
        {
            for (int j = 0; j < arrInt.GetLength(1); j++)
            {
                Console.Write("{0,4}", arrInt[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Input dimension of the maatrix:");
        int dimensionMatrix = int.Parse(Console.ReadLine());
        int[,] arrayInt = new int[dimensionMatrix, dimensionMatrix];

        int row = dimensionMatrix - 1;
        int col = 0;

        for (int counter = 1; counter <= arrayInt.Length; counter++)
        {
            arrayInt[row, col] = counter;
            row++;
            col++;
            if (row == dimensionMatrix || col == dimensionMatrix)
            {
                row--;
                while (col > 0 && row > 0)
                {
                    row--;
                    col--;
                }
            }
        }
        PrintArrayInt(arrayInt);
    }
}



