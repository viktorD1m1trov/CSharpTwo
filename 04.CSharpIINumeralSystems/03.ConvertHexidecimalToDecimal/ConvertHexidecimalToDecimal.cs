// 4.Write a program to convert hexadecimal numbers to their decimal representation.


using System;

class ConvertHexidecimalToDecimal
{

    static int baseNumSystem = 16;

    static void Main()
    {
        Console.Write("Input  hexadecimal number:");
        string strHexidecimal = Console.ReadLine();
        string reversedStr = ReverseString(strHexidecimal);

        Console.WriteLine("Decimal representation: {0}", HexidecimalToDecimal(reversedStr));
    }

    static int HexidecimalToDecimal(string stringHex)
    {
        int decimalNumber = 0;
        for (int i = 0; i < stringHex.Length; i++)
        {
            char temp=stringHex[i];
            switch (temp)
            {
                case 'A': decimalNumber += 10 * (int)Math.Pow(baseNumSystem, i); break;
                case 'B': decimalNumber += 11 * (int)Math.Pow(baseNumSystem, i); break;
                case 'C': decimalNumber += 12 * (int)Math.Pow(baseNumSystem, i); break;
                case 'D': decimalNumber += 13 * (int)Math.Pow(baseNumSystem, i); break;
                case 'E': decimalNumber += 14 * (int)Math.Pow(baseNumSystem, i); break;
                case 'F': decimalNumber += 15 * (int)Math.Pow(baseNumSystem, i); break;
                default: decimalNumber += (stringHex[i] - 48) * (int)Math.Pow(baseNumSystem, i); break;
            }
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

