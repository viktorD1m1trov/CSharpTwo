//   3.Write a program that prints to the console 
//   which day of the week is today. Use System.DateTime.


using System;

class PrintDayOfToday
{
    static void Main()
    {
        DateTime dateTime =  DateTime.Now;
        Console.WriteLine("Today is {0}",dateTime.DayOfWeek);

    }
}

