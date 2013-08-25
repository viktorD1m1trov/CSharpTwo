//  02.Write a method ReadNumber(int start, int end) that enters an integer number 
//  in given range [start…end]. If an invalid number or non-number text is entered, 
//  the method should throw an exception. Using this method write a program that enters 10 numbers:
//              a1, a2, … a10, such that 1 < a1 < … < a10 < 100



using System;

class ReadIntegerNumberInterval
{
    public const int numbersInSequence = 10;
    public const int startInterval = 1;
    public const int endInterval = 100;

    public static int counter = 1;



    public static void ReadNumber(int start, int end)
    {

        Console.Write("a[{0}] in range[{1},{2}]", counter, start, end);
        int startNumber = int.Parse(Console.ReadLine());

        if (startNumber < start || startNumber > end)
        {
            //the input number is not in appropriate interval
            throw new ArgumentOutOfRangeException(String.Format("NOT IN A RANGE [{0},{1}]! ", start, end));
        }

        start = startNumber;
        counter++;
        if (counter > numbersInSequence) //only to numbersInSequence(10) 
        {
            return;
        }
        // recursion -  call the  method itself
        ReadNumber(start, end);
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Input {0} integer numbers a1, a2, … a10,\n such that 1 < a1 < … < a10 < 100 ", numbersInSequence);
            ReadNumber(startInterval, endInterval);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Not a valid integer number!!!");
            Console.WriteLine(fe.StackTrace);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("ERROR:",ex.Message);
            throw;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Out of integer range[{0},{1}]!!!", int.MinValue, int.MaxValue);
        }
    }

}

