//  9.Write a method that return the maximal element in a portion of array 
//  of integers starting at given index. Using it write another method that
//  sorts an array in ascending / descending order.



using System;

class MaxElementInPortionArrayAndSort
{
    static Random generator = new Random();

    static void Main()
    {
        Console.Write("Size of array to generate:");
        int sizeArray = int.Parse(Console.ReadLine());
        int[] arrayInt = new int[sizeArray];
        GenerateArray(arrayInt);
        PrintArray(arrayInt);

        Console.Write("Input index of element:");
        int index = int.Parse(Console.ReadLine());

        int maxElement = arrayInt[FindMaximalElementInArray(arrayInt, index)];
        Console.WriteLine("Maximal element in a portion from index {0} is {1}",index,maxElement);

        Console.WriteLine("Sorted array in descending order:");
        SelectionSortDecsendingOrder(arrayInt);
        PrintArray(arrayInt);
    }

    static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void SelectionSortDecsendingOrder(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Swap(arr, i, FindMaximalElementInArray(arr, i));
        }
    }
    
    static int FindMaximalElementInArray(int[] arr, int index)
    {
        int indexMax = index;
        for (int i = index; i < arr.Length; i++)
        {
            if (arr[i]>arr[indexMax])
            {
                indexMax=i;
            }
        }
        return indexMax;
    }

    static void GenerateArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = generator.Next(-1000, 1000);
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (int index in arr)
        {
            Console.Write("{0} ", index);
        }
        Console.WriteLine();
    }
}

