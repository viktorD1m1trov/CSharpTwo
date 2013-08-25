//  02.Write a method ReadNumber(int start, int end) that enters an integer number 
//  in given range [start…end]. If an invalid number or non-number text is entered, 
//  the method should throw an exception. Using this method write a program that enters 10 numbers:
//              a1, a2, … a10, such that 1 < a1 < … < a10 < 100



using System;

class ReadIntegerNumberInterval
{
    public const int numberSequence = 10;
    public const int startInterval = 1;
    public const int endInterval = 100;
    public static int counter = 1;



    public static void ReadNumber(int start, int end)
    {

        Console.Write("a[{0}] in range[{1},{2}]", counter, start, end);
        int startNumber = int.Parse(Console.ReadLine());
        if (startNumber < start || startNumber > end)
            throw new OutOfRangeException();
        
        start = startNumber;
        counter++;
        if (counter > 10)
        {
            return;
        }
        ReadNumber(start, end);
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Input {0} integer numbers a1, a2, … a10,\n such that 1 < a1 < … < a10 < 100 ", numberSequence);
            ReadNumber(startInterval, endInterval);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Not a valid integer number!!!");
            Console.WriteLine(fe.StackTrace);
        }
        catch (OutOfRangeException ex)
        {
            ex.PrintMassage();
        }
    }
}

class OutOfRangeException : ArgumentException
{
    private string massage = "Number out of range!";
    public void PrintMassage()
    {
        Console.WriteLine(massage);
    }
}
