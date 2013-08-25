//  2.Write a method GetMax() with two parameters that returns the bigger 
//  of two integers. Write a program that reads 3 integers from the console 
//  and prints the biggest of them using the method GetMax().


using System;
using System.Collections.Generic;

class FindTheBiggestOfThreeIntegers
{
    static int GetMax(int firstInt, int secondInt)
    {
        if (firstInt >= secondInt)
        {
            return firstInt;
        }
        else
        {
            return secondInt;
        }
    }

    static void Main()
    {
        List<int> listInt = new List<int>();

        Console.WriteLine("Input 3 numbes:");
        for (int index = 0; index < 3; index++)
        {
            Console.Write("{0}.", index+1);
            listInt.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("The biggest one is {0}",GetMax(listInt[0], GetMax(listInt[1], listInt[2])));
    }
}

