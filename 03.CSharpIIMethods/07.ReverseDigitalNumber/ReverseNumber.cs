//  7.Write a method that reverses the digits of given decimal number.
// Example: 256  652


using System;

class ReverseDigitalNumber
{
    static void Main()
    {
        Console.WriteLine("Input number to reverse:");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        Console.WriteLine("With integer:");
        ReverseNumber(number);
        Console.WriteLine("With string");
        ReverseNumber(numberString);
    }

    static void ReverseNumber(int num)
    {
        int temp = num;
        while (num > 0)
        {
            temp = num % 10;
            Console.Write(temp);
            num /= 10;
        }
        Console.WriteLine();
    }

    static void ReverseNumber(string str)
    {
        for (int index = str.Length - 1; index >= 0; index--)
        {
            Console.Write(str[index]);
        }
        Console.WriteLine();
    }
}

