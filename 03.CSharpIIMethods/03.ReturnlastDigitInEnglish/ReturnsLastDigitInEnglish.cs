//  3.Write a method that returns the last digit of given integer as an English word.
//  Examples: 512  "two", 1024  "four", 12309  "nine".



using System;

class ReturnsLastDigitInEnglish
{
    static void LastDigitInEnglish(int number)
    {
        int lastDigit = LastDigit(number);
        switch (lastDigit)
        {
            case 0:
                {
                    Console.WriteLine("zero"); break;
                }
            case 1:
                {
                    Console.WriteLine("one"); break;
                }
            case 2:
                {
                    Console.WriteLine("two"); break;
                }
            case 3:
                {
                    Console.WriteLine("three"); break;
                }
            case 4:
                {
                    Console.WriteLine("four"); break;
                }
            case 5:
                {
                    Console.WriteLine("five"); break;
                }
            case 6:
                {
                    Console.WriteLine("six"); break;
                }
            case 7:
                {
                    Console.WriteLine("seven"); break;
                }
            case 8:
                {
                    Console.WriteLine("eight"); break;
                }
            case 9:
                {
                    Console.WriteLine("nine"); break;
                }            
        }
    }

    static int LastDigit(int usernumber)
    {
        return usernumber % 10;
    }

    static void Main()
    {
        Console.Write("Input a number: ");
        int numberInt = int.Parse(Console.ReadLine());
        LastDigitInEnglish(Math.Abs(numberInt));
    }
}

