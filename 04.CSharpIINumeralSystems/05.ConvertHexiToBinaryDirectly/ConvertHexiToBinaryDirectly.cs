//5.Write a program to convert hexadecimal numbers to binary numbers (directly).


using System;

class ConvertHexiToBinaryDirectly
{
    static void Main()
    {
        Console.Write("Input  hexadecimal number:");
        string strHexidecimal = Console.ReadLine();
        string resultString = HexidecimalToBinary(strHexidecimal);
        Console.WriteLine("Binary representation {0}",resultString);
    }

   
    static string HexidecimalToBinary(string stringHex)
    {
        string binaryStr = "";
        for (int i = 0; i < stringHex.Length; i++)
        {
            char temp = stringHex[i];
            switch (temp)
            {
                case '0': binaryStr += "0000"; break;          
                case '1': binaryStr += "0001"; break;
                case '2': binaryStr += "0010"; break;
                case '3': binaryStr += "0011"; break;
                case '4': binaryStr += "0100"; break;
                case '5': binaryStr += "0101"; break;
                case '6': binaryStr += "0110"; break;
                case '7': binaryStr += "0111"; break;
                case '8': binaryStr += "1000"; break;
                case '9': binaryStr += "1001"; break;             
                case 'A': binaryStr += "1010"; break;
                case 'B': binaryStr +="1011"; break;
                case 'C': binaryStr +="1100"; break;
                case 'D': binaryStr +="1101"; break;
                case 'E': binaryStr +="1110"; break;
                case 'F': binaryStr +="1111"; break;
                default: Console.WriteLine("What?"); break;
            }
        }
        return binaryStr.TrimStart('0');
    }
}

