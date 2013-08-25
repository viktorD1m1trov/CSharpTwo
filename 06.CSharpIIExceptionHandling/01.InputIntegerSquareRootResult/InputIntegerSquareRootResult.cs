//  01.Write a program that reads an integer number and calculates and prints
//  its square root. If the number is invalid or negative, print "Invalid number". 
//  In all cases finally print "Good bye". Use try-catch-finally.


using System;

class InputIntegerSquareRootResult
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Lets calculate square root of integer number: ");
                uint numberInt = uint.Parse(Console.ReadLine());
                Console.WriteLine("Sqare root is {0}",Math.Sqrt(numberInt));
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good buy");
            }
        }

    }
}

