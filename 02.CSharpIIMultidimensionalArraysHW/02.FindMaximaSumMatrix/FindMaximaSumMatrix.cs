//  2.Write a program that reads a rectangular matrix of size N x M and finds in
//  it the square 3 x 3 that has maximal sum of its elements.


using System;

class FindMaximaSumMatrix
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
        
        int[,] matrixNM =
        {
           {2,3,4,4},
           {3,4,5,5},
           {5,6,7,7},
           { 2,3,4,4},
           {5,6,0,9}
        };

        PrintArrayInt(matrixNM);

        int maxSum = int.MinValue;
        int leftIndex = 0;
        int topIndex = 0;

        for (int i = 0; i < matrixNM.GetLength(0)-2; i++)
        {
            int currentSum = 0;

            for (int j = 0; j < matrixNM.GetLength(1)-2; j++)
            {
                currentSum=matrixNM[i,j]+matrixNM[i+1,j]+matrixNM[i+2,j]+
                            matrixNM[i,j+1]+matrixNM[i,j+2]+matrixNM[i+1,j+1]+
                            matrixNM[i+2,j+2]+matrixNM[i+1,j+2]+matrixNM[i+2,j+1];

                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    leftIndex = i;
                    topIndex = j;
                        
                }
            }
        }
        Console.WriteLine("Maximal sum is {0} in segment matrix:" ,maxSum);

        for (int i = leftIndex; i < leftIndex+3; i++)
        {
            for (int j = topIndex; j < topIndex+3; j++)
            {
                Console.Write("{0,4}",matrixNM[i,j]);
            }
            Console.WriteLine();
        }
    }
}

