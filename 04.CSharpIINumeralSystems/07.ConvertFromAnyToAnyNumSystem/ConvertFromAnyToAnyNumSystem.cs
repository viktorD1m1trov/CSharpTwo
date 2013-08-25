//  7.Write a program to convert from any numeral system of given base s 
//  to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Text;

class ConvertFromAnyToAnyNumSystem
{
    static void Main()
    {
        Console.Write("Input base for input number:");
        byte baseInputNumber = byte.Parse(Console.ReadLine());
        Console.Write("Input number: ");
        string inputNumberString = Console.ReadLine();
        Console.Write("What will be the base of new number: ");
        byte baseResultNumber = byte.Parse(Console.ReadLine());

        long resultDecimal=FromAnyToDecimal(inputNumberString, baseInputNumber);
       // Console.WriteLine(resultDecimal);
        Console.WriteLine(FromDecimalToAny(resultDecimal, baseResultNumber));


    }

    static long FromAnyToDecimal(string numberStr, int baseNumSystem)
    {
        long decimalNumber = 0;
        for (int i = numberStr.Length - 1; i >= 0; i--)
        {
            char temp = numberStr[i];
            switch (temp)
            {
                case 'A': decimalNumber += 10 * (int)Math.Pow(baseNumSystem, numberStr.Length - 1 - i); break;
                case 'B': decimalNumber += 11 * (int)Math.Pow(baseNumSystem, numberStr.Length - 1 - i); break;
                case 'C': decimalNumber += 12 * (int)Math.Pow(baseNumSystem, numberStr.Length - 1 - i); break;
                case 'D': decimalNumber += 13 * (int)Math.Pow(baseNumSystem, numberStr.Length - 1 - i); break;
                case 'E': decimalNumber += 14 * (int)Math.Pow(baseNumSystem, numberStr.Length - 1 - i); break;
                case 'F': decimalNumber += 15 * (int)Math.Pow(baseNumSystem, numberStr.Length - 1 - i); break;
                default: decimalNumber += (numberStr[i] - 48) * (int)Math.Pow(baseNumSystem, numberStr.Length - 1 - i); break;
            }
        }
        return decimalNumber;
    }

    static string FromDecimalToAny(long resultDecimaLong, byte baseResultNumber)
    {
        StringBuilder sb = new StringBuilder();

        while (resultDecimaLong > 0)
        {
            long temp = resultDecimaLong % baseResultNumber;
            switch (temp)
            {
                case 10: sb.Append("A"); break;
                case 11: sb.Append("B"); break;
                case 12: sb.Append("C"); break;
                case 13: sb.Append("D"); break;
                case 14: sb.Append("E"); break;
                case 15: sb.Append("F"); break;
                default: sb.Append(temp); break;
            }

            resultDecimaLong /= baseResultNumber;
        }

        return ReverseText(sb.ToString());
    }

    public static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
            sb.Append(text[i]);
        return sb.ToString();
    }

}

