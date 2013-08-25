//      13.Write a program that can solve these tasks:
//      Reverses the digits of a number
//      Calculates the average of a sequence of integers
//      Solves a linear equation a * x + b = 0
//              Create appropriate methods.
//              Provide a simple text-based menu for the user to choose which task to solve.
//              Validate the input data:
//      The decimal number should be non-negative
//      The sequence should not be empty
//      a should not be equal to 0

using System;

class MenuComplicatedTask

{
    static int selectedOption = 0;

    static int PrintTextBasedMenu()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Enter number of option you want to choise:");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("1. Reverses the digits of a number");
        Console.WriteLine("2. Calculates the average of a sequence of integers");
        Console.WriteLine("3. Solves a linear equation a * x + b = 0");
        Console.WriteLine("\nFor example: 1, 2, 3 ...");
        selectedOption = int.Parse(Console.ReadLine());

        return selectedOption;
    }

    static void ReverseDigitOfNumber()
    {
        Console.WriteLine("\nEnter positive decimal numbers to reverse:");

        string digits = Console.ReadLine();
        while (digits.Substring(0, 1) == "-")
        {
            Console.WriteLine("The decimal number should be non-negative. Please try again!");
            digits = Console.ReadLine();
        }

        Console.WriteLine("\nRepresent ot this number is:");

        for (int i = digits.Length - 1, count = 0; i >= 0; i--, count++)
        {
            Console.Write("{0}", digits.Substring(i, 1));
        }
        Console.WriteLine("\n");
    }

    static void FindAverageOfSequenceIntegers()
    {
        Console.WriteLine("\nEnter length of sequence:");
        int length = int.Parse(Console.ReadLine());
        while (length <= 0)
        {
            Console.WriteLine("The sequnce should not be empty. Please try again!");
            length = int.Parse(Console.ReadLine());
        }

        Console.Write("n0 = ");
        int sum = int.Parse(Console.ReadLine());

        for (int i = 1; i < length; i++)
        {
            Console.Write("n{0} = ", i);
            sum = sum + int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe avarage of the sequence is: {0}", sum / length);
    }

    static void SolveLinearEquation()
    {
        Console.WriteLine("\nEnter coefficients of linear equation:");
        Console.WriteLine("a = ");
        double coefficientA = double.Parse(Console.ReadLine());

        while (coefficientA == 0)
        {
            Console.WriteLine("Invaled number: a should not be equal to 0. Please try again!");
            coefficientA = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("b = ");
        double coefficientB = double.Parse(Console.ReadLine());
        Console.WriteLine("\nResult: x = {0}", -coefficientB / coefficientA);
    }

    static void Main()
    {
        PrintTextBasedMenu();
        if (selectedOption == 1)
        {
            ReverseDigitOfNumber();
        }
        else if (selectedOption == 2)
        {
            FindAverageOfSequenceIntegers();
        }
        else if (selectedOption == 3)
        {
            SolveLinearEquation();
        }
        else
        {
            Console.WriteLine("You have entered invalid option!");
        }
    }
}