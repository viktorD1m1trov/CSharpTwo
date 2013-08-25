//3.Write a program to convert decimal numbers to their hexadecimal representation.


using System;
using System.Collections.Generic;

class ConvertDecimalToHexidecimal
{
    static void Main()
    {

        Console.Write("Input positive decimal number: ");
        int numberDecimal = int.Parse(Console.ReadLine());

        int baseNumeralSystem = 16;
        string resultList = ConvertToHexidecimal(numberDecimal, baseNumeralSystem);
        Console.Write("Hexidecimal representation: ");
        Console.WriteLine(ReverseString(resultList));
    }

    static string ConvertToHexidecimal(int numDecimal, int baseNumSystem)
    {
        string representationString = "";
        while (numDecimal > 0)
        {
            int temp = numDecimal % baseNumSystem;
            if (temp == 10)
            {
                representationString += "A";
            }
            else if (temp == 11)
            {
                representationString += "B";

            }
            else if (temp == 12)
            {
                representationString += "C";

            }
            else if (temp == 13)
            {
                representationString += "D";

            }
            else if (temp == 14)
            {
                representationString += "E";

            }
            else if (temp == 15)
            {
                representationString += "F";

            }
            else
            {
                representationString += temp.ToString();
            }
            numDecimal /= baseNumSystem;
        }
        return representationString;

    }

    static string ReverseString(string str)
    {
        string reversedString = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedString += str[i];
        }
        return reversedString;
    }

}

