
//  8.Write a program that shows the binary representation of given 
//  16-bit signed integer number (the C# type short).


using System;

class ShowBinaryRepresentationOfShorts
{
    static void Main()
    {
        Console.WriteLine("Input short number: ");
        short numberShort = short.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation : {0}",GetShortBinaryString(numberShort));
    }

     static string GetShortBinaryString(short numShort)
    {
        char[] b = new char[16];
        byte pos = 15;
        byte i = 0;
        while (i<16)
        {
            if ((numShort&(1<<i))!=0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
    
        }
        return new string(b).TrimStart('0');

    }

}

