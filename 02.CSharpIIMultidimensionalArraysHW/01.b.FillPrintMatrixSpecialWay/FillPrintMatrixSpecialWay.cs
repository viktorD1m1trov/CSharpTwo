//  1.b.Write a program that fills and prints a matrix of size (n, n)
//  as shown below: (examples for n = 4)


using System;

class FillPrintMatrixSpecialWay
{
   
   static void PrintArrayInt(int[,]arrInt)
{
    for (int i = 0; i < arrInt.GetLength(0); i++)
    {
        for (int j = 0; j < arrInt.GetLength(1); j++)
        {
            Console.Write("{0,4}",arrInt[i,j]);
        }
        Console.WriteLine();
    }
}
    
    static void Main()
    {
        Console.WriteLine("Input dimension of the maatrix:");
        int dimensionMatrix = int.Parse(Console.ReadLine());
        int[,] arrayInt = new int[dimensionMatrix, dimensionMatrix];
        int curretValue = 1;

        for (int col = 0; col <arrayInt.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < arrayInt.GetLength(0); row ++)
                {

                    arrayInt[row, col] = curretValue;
                    curretValue++;
                }

            }
            else
            {
                for (int row2 = arrayInt.GetLength(0)-1; row2 >= 0; row2--)
                {
                    arrayInt[row2, col] = curretValue;
                    curretValue++;

                }
            }
        }

        PrintArrayInt(arrayInt);
    }

}

