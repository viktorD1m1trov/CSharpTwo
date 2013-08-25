//  1.Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;

class ConvertDecimalToBinary
{
    static void Main()
    {
        Console.Write("Input positive decimal number:");
        int numberDecimal = int.Parse(Console.ReadLine());

        Console.Write("Input base of numeral system to convert[2..9]:");
        int baseNumeralSystem = int.Parse(Console.ReadLine());
        //int baseNumeralSystem = 2;

        List<int> resultList = new List<int>();
        resultList = ConvertToAnyNumSystem(numberDecimal, baseNumeralSystem);
        resultList.Reverse();

        Console.Write("Representation in ({0}) numeral system:",baseNumeralSystem);
        PrintList(resultList);
    }
    

    static List<int> ConvertToAnyNumSystem(int decimalNumber, int baseNumSystem)
    {
        List<int> representationList = new List<int>();
        while (decimalNumber > 0)
        {
            
            representationList.Add(decimalNumber % baseNumSystem);
            decimalNumber /= baseNumSystem;
        }

        return representationList;
    }

    static void PrintList(List<int> list)
    {
        foreach (var member in list)
        {
            Console.Write(member);
        }
        Console.WriteLine();
    }
}

