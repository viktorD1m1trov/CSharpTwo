//  3.We are given a matrix of strings of size N x M. Sequences in the matrix we define as
//  sets of several neighbor elements located on the same line, column or diagonal. 
//  Write a program that finds the longest sequence of equal strings in the matrix. Example:


using System;

class FindLongest_SequenceStringInMatrix
{

    static void PrintMatrixStrings(string[,] arrStr)
    {
        for (int i = 0; i < arrStr.GetLength(0); i++)
        {
            for (int j = 0; j < arrStr.GetLength(1); j++)
            {
                Console.Write("{0 }", arrStr[i, j].PadRight(5));

            }
            Console.WriteLine();
        }

    }

    static void Paralel(string[,] arr, out int bestCount, out string bestString)
    {
        int count = 1;
        bestCount = 1;
        bestString = "";
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 1; col++)
            {
                for (int i = col; i < arr.GetLength(1) - 1; i++)
                {
                    if (arr[row, i] == arr[row, i + 1])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestString = arr[row, col] + "\nparalel";
                    }
                }
                count = 1;

            }
        }

    }

    static void Meridian(string[,] arr, ref int bestCount, ref string bestString)
    {
        int count = 1;
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int i = row; i < arr.GetLength(0) - 1; i++)
                {
                    if (arr[i, column] == arr[i + 1, column])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestString = arr[row, column] + "\nmeridian";
                    }
                }
                count = 1;
            }
        }

    }

    static void DiagonalsDownRight(string[,] arr, ref int bestCount, ref string bestString)
    {
        int count = 1;
        for (int rows = 0; rows < arr.GetLength(0) - 2; rows++)  //moves diagonal left/down
        {
            for (int row = rows, col = 0; row < arr.GetLength(0) - 1; row++, col++)
            {
                if ((row == arr.GetLength(0) - 1) || (col == arr.GetLength(1) - 1)) break;
                if (arr[row, col] == arr[row + 1, col + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestString = arr[row, col] + "\ndiagonals down/right";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
        for (int cols = 1; cols < arr.GetLength(0) - 2; cols++)  //moves diagonal to right
        {
            for (int row = 0, col = cols; row < arr.GetLength(0) - 1; row++, col++)
            {
                if ((row == arr.GetLength(0) - 1) || (col == arr.GetLength(1) - 1)) break;
                if (arr[row, col] == arr[row + 1, col + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestString = arr[row, col] + "\ndiagonals down/right";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
    }

    static void DagonalsDownLeft(string[,] arr, ref int bestCount, ref string bestString)
    {
        //ckeck diagonals down-left
        int count = 1;
        for (int rows = 0; rows < arr.GetLength(0) - 1; rows++)  //moves diagonal left/down
        {
            for (int row = rows, col = arr.GetLength(1) - 1; row < arr.GetLength(0) - 1; row++, col--)
            {
                if ((row == arr.GetLength(0) - 1) || (col == 0)) break;
                if (arr[row, col] == arr[row + 1, col - 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestString = arr[row, col] + "\ndiagonals down/left";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
        for (int cols = arr.GetLength(1) - 2; cols >= 1; cols--)  //moves diagonal to right
        {
            for (int row = 0, col = cols; row < arr.GetLength(0) - 1; row++, col--)
            {
                if ((row == arr.GetLength(0) - 1) || (col == 0)) break;
                if (arr[row, col] == arr[row + 1, col - 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestString = arr[row, col] + "\ndiagonals down/left";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
    }



    static void Main()
    {
        string[,] matrixString = 
        {
        {"ha","fifi","ho","ho" },
        {"fo","ha","ho","xx"},
        {"xxx","ho","hi","xx"}
         };

        // string[,] matrix = { { "s", "qq", "s" }, { "pp", "pp", "s" }, { "pp", "qq", "s" } };

        PrintMatrixStrings(matrixString);

        int bestSequence = 0;
        string mostPopularString = "";

        Paralel(matrixString, out bestSequence, out mostPopularString);
        Meridian(matrixString, ref bestSequence, ref mostPopularString);
        DiagonalsDownRight(matrixString, ref bestSequence, ref mostPopularString);
        DagonalsDownLeft(matrixString, ref bestSequence, ref mostPopularString);

        Console.WriteLine("Longest sequence of equal strings in the matrix: " + mostPopularString);
        Console.WriteLine(bestSequence + " times");


    }
}

