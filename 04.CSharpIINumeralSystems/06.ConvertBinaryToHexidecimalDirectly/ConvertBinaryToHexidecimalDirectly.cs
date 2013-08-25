//  6.Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class ConvertBinaryToHexidecimalDirectly
{

    static void Main()
    {
        Console.Write("Input  binary number:");
        string stringBinary = Console.ReadLine();
        string resultString = BinaryToHexidecimal(stringBinary);
        Console.WriteLine("Hexidecimal representation: {0}",resultString);

    }

    static string AddLeadingZeros(string str)
    {
        
        StringBuilder sb = new StringBuilder();


        if (str.Length % 4 != 0)
        {
            //reverse string
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);

            }
            //add leading zeros
            int numberOfLeadingZeros = 4 - (str.Length % 4);
            sb.Append('0', numberOfLeadingZeros);

            return (ReverseText(sb.ToString()));
        }
        else
        {
            return str;
        }
    }

    public static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
            sb.Append(text[i]);
        return sb.ToString();
    }

    static string BinaryToHexidecimal(string stringBin)
    {
        string normalizedStr = AddLeadingZeros(stringBin);
        string resultString = "";
        for (int i = 0; i < normalizedStr.Length; i=i+4)
        {

            string substring = normalizedStr.Substring(i, 4);
            switch (substring)
            {
                case "0000": resultString +="0" ; break;
                case "0001": resultString +="1"; break;
                case "0010": resultString +="2"; break;
                case "0011": resultString +="3"; break;
                case "0100": resultString +="4"; break;
                case "0101": resultString +="5"; break;
                case "0110": resultString +="6"; break;
                case "0111": resultString +="7"; break;
                case "1000": resultString +="8"; break;
                case "1001": resultString +="9"; break;
                case "1010": resultString +="A"; break;
                case "1011": resultString +="B"; break;
                case "1100": resultString +="C"; break;
                case "1101": resultString +="D"; break;
                case "1110": resultString += "E"; break;
                case "1111": resultString += "F"; break;
            }
        }
        return resultString;
    }
}




