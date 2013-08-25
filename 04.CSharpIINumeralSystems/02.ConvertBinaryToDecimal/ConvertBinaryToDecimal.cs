//  2.Write a program to convert binary numbers to their decimal representation.
using System;

class ConvertBinaryToDecimal
{
    static int baseNumSystem = 2;

    static void Main()
    {
        Console.Write("Input  binary number:");
        string strBinary = Console.ReadLine();
        string reversedStr = ReverseString(strBinary);

        Console.WriteLine(BinaryToDecimal(reversedStr));
    }

    static int BinaryToDecimal(string stringBin)
    {
        int decimalNumber = 0;
        for (int i = 0; i < stringBin.Length; i++)
        {
            decimalNumber += (stringBin[i] - 48) * (int)Math.Pow(baseNumSystem, i);
        }
        return decimalNumber;
    }


    static string ReverseString(string str)
    {
        string reversedString = "";
        for (int i = 0; i < str.Length; i++)
        {
            reversedString += str[str.Length - i - 1];
        }
        return reversedString;
    }
}

