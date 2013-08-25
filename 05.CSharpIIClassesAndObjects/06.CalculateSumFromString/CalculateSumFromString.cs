//6.You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461
using System;

class CalculateSumFromString
{
    static void Main()
    {
        string stringOfNumbers = ("   123 34 2 1 34 45 5 12 3 2");
        
        // remove witespaces from the beginning and end
        stringOfNumbers = stringOfNumbers.Trim();

        Console.WriteLine(stringOfNumbers);

        string[] numbersStringsArray = stringOfNumbers.Split(' ');
        int sum = 0;
        foreach (string numberStr in numbersStringsArray)
        {
            sum += int.Parse(numberStr.Trim());
        }
        Console.WriteLine("The sum is {0}",sum);
    }
}

