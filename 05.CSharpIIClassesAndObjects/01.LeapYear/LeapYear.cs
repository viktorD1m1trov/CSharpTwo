//  1.Write a program that reads a year from the console
//  and checks whether it is a leap. Use DateTime.


using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Input a year: ");
        int yearInput = int.Parse(Console.ReadLine());
        if(IsLeapYear(yearInput) )
        {
            Console.WriteLine("{0} is leap  year.", yearInput);
        }
        else
        {
            Console.WriteLine("{0} is not leap  year.", yearInput);
        }
    }

    public static bool IsLeapYear(int yearInt)
    {
        return DateTime.IsLeapYear(yearInt);
    }

    
}

