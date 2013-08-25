//  4.Write a method that counts how many times given number appears in given array. 
//  Write a test program to check if the method is working correctly.
using System;

class CountsNumberInArray
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input number of values in array: ");
        int dimension = int.Parse(Console.ReadLine());

        Console.WriteLine("  {m} manual input, {a} automatic generation");
        string input = Console.ReadLine();

        int[] arrayInt = new int[dimension];
        
        if (input == "m")
        {
            for (int i = 0; i < dimension; i++)
            {
                Console.Write("arr[{0}]= ", i);
                arrayInt[i] = int.Parse(Console.ReadLine());
            }
        }
        else if (input == "a")
        {
            arrayInt = GenerateArray(dimension);

        }
        PrintVektor(arrayInt);

        Console.WriteLine("Input number to search for:");
        int searchedNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The repetition of {0} is {1} times.",searchedNumber, CountRepetition(arrayInt,searchedNumber));


    }

    static int CountRepetition(int[] arrInt, int searchedNumber)
    {
        int countRepetition = 0;
        foreach (int number in arrInt)
        {
            if (number==searchedNumber)
            {
                countRepetition++;
            }
        }
        return countRepetition;
    }

    static int[] GenerateArray(int dimension)
    {
        int[] arrInt = new int[dimension];
        Random randomGenerator = new Random();
        for (int i = 0; i < arrInt.Length; i++)
        {

            arrInt[i] = randomGenerator.Next(0, 101);
        }
        return arrInt;
    }

    static void PrintVektor(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

