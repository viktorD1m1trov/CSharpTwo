//  5.You are given an array of strings. Write a method that sorts the array
//  by the length of its elements (the number of characters composing them).


using System;

class SortStringMatrixByLength
{

    static void PrintArrayStrings(string[] arrStr)
    {
        foreach (string str in arrStr)
        {
            Console.Write(str+" ");
        }
        Console.WriteLine();
    }

    static void MatrixStringsLengthSort(string[] arrStr)
    {
        for (int i = 0; i < arrStr.Length; i++)
        {
            for (int j = i; j < arrStr.Length; j++)
            {
                if (arrStr[i].Length < arrStr[j].Length)
                {
                    string temp = arrStr[i];
                    arrStr[i] = arrStr[j];
                    arrStr[j] = temp;

                }
            }
        }
    
    }
    
    static void Main()
    {
        string[] arrayStrings = { "qeeqweq","a", "qwesfsdfsdsd", "fase", "tyrt", "urtu", "ytyuyu74", 
                                    "tuytu", "ytutyu", "gfhfh", "uu"};
        Console.WriteLine("Unsorted array:");
        PrintArrayStrings(arrayStrings);

        MatrixStringsLengthSort(arrayStrings);

        Console.WriteLine("Sorted array:");
        PrintArrayStrings(arrayStrings);
    }
}

