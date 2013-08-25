//  1.d.Write a program that fills and prints a matrix of size (n, n)
//  as shown below: (examples for n = 4)


using System;

class FillPrintMatrixSpecialWay
{
    static void Main()
    {
        uint inputNUint;

        while (true)
        {
            Console.Write("N = ");
            string inputNString = Console.ReadLine();
            if (uint.TryParse(inputNString, out inputNUint) == true)
            {
                break;
            }
        }
        int[,] spiralMatrix = new int[inputNUint, inputNUint];

        int[,] direction =
        {
           {1,0},  //down rowInDirectionMatrix=1
           {0,1},  //right rowInDirectionMatrix=0
           {-1,0}, //up rowInDirectionMatrix=3
           {0,-1}//left rowInDirectionMatrix=2

        };
        Console.WriteLine(direction.GetLength(0));
        Console.WriteLine(direction.GetLength(1));

        int currentRow = 0;
        int currentColumn = 0;

        int currentCellValue = 1;
        int rowInDirectionMatrix = 0; //shows direction(row in direction matrix)


        while (currentCellValue <= inputNUint * inputNUint)
        {
            spiralMatrix[currentRow, currentColumn] = currentCellValue;

            int nextRow = currentRow + direction[rowInDirectionMatrix, 0];
            int nextColumn = currentColumn + direction[rowInDirectionMatrix, 1];

            bool isInMatrix = nextRow >= 0 && nextRow < spiralMatrix.GetLength(0) && nextColumn >= 0 && nextColumn < spiralMatrix.GetLength(1);

            if (!isInMatrix || spiralMatrix[nextRow, nextColumn] != 0)
            {
                rowInDirectionMatrix++;
                if (rowInDirectionMatrix == 4)
                {
                    rowInDirectionMatrix = 0;
                }
            }
            currentRow += direction[rowInDirectionMatrix, 0];
            currentColumn += direction[rowInDirectionMatrix, 1];

            currentCellValue++;
        }

        for (int i = 0; i < spiralMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < spiralMatrix.GetLength(1); j++)
            {
                Console.Write("{0,5}", spiralMatrix[i, j]);
            }

            Console.WriteLine();
        }

    }
}