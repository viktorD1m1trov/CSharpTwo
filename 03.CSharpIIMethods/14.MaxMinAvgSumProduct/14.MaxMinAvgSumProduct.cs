
//  14.Write methods to calculate minimum, maximum, average, sum and product
//  of given set of integer numbers. Use variable number of arguments.



using System;

class MaxMinAvgSumProduct
{
    static Random generator = new Random();

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


    static int FindMax(params int[] arr)
    {
        int biggestNum = arr[0];
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if (length > 0)
            {
                if (arr[i] > biggestNum)
                {
                    biggestNum = arr[i];
                }
            }
            else
            {
                return 0;
            }
        }
        return biggestNum;
    }

    static int FindMin(params int[] arr)
    {
        int smallest = arr[0];
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if (length > 0)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            else
            {
                return 0;
            }
        }
        return smallest;
    }

    static decimal FindAvg(params int[] arr)
    {
        decimal counter = 0;
        decimal sum = 0;
        decimal sumAvg = 0;
        foreach (var number in arr)
        {
            sum = sum + number;
            counter++;
        }
        sumAvg = sum / counter;
        return sumAvg;
    }

    static int FindSum(params int[] arr)
    {
        int sum = 0;
        foreach (var number in arr)
        {
            sum += number;
        }
        return sum;
    }
    static int FindProduct(params int[] arr)
    {
        int product = 1;
        foreach (var number in arr)
        {
            product *= number;
        }
        return product;
    }
    static void Main()
    {
        Console.Write("Size of array to generate:");
        int sizeArray = int.Parse(Console.ReadLine());
        int[] arrayInt = new int[sizeArray];
        GenerateArray(arrayInt);
        PrintArray(arrayInt);

        Console.WriteLine("Min={0}", FindMin(arrayInt));
        Console.WriteLine("Max={0}", FindMax(arrayInt));
        Console.WriteLine("Avg={0}", FindAvg(arrayInt));
        Console.WriteLine("Sum={0}", FindSum(arrayInt));
        Console.WriteLine("Product={0}", FindProduct(arrayInt));
        Console.WriteLine();

        Console.WriteLine("1,2,3,4");
        Console.WriteLine("Min={0}", FindMin(1, 2, 3, 4));
        Console.WriteLine("Max={0}", FindMax(1, 2, 3, 4));
        Console.WriteLine("Avg={0}", FindAvg(1, 2, 3, 4));
        Console.WriteLine("Sum={0}", FindSum(1, 2, 3, 4));
        Console.WriteLine("Product={0}", FindProduct(1, 2, 3, 4));
        Console.WriteLine();
    }
}

