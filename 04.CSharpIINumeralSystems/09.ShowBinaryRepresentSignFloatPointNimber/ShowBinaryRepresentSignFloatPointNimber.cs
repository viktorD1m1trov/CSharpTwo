//  9.Write a program that shows the internal binary representation of given 32-bit 
//  signed floating-point number in IEEE 754 format (the C# type float). 
//  Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.


using System;
using System.Globalization;
using System.Threading;

class ShowBinaryRepresentSignFloatPointNimber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        Console.Write("Input float number use (.) for separator please : ");
        float numberFloat = float.Parse(Console.ReadLine());

        int integerBits = BitConverter.ToInt32(BitConverter.GetBytes(numberFloat), 0);
        string input = Convert.ToString(integerBits, 2);
        input = input.PadLeft(32, '0');
        string sign = input.Substring(0, 1);
        string exponent = input.Substring(1, 8);
        string mantissa = input.Substring(9, 23);

        Console.WriteLine("The binary representqation of floating point number: {0}", numberFloat);
        Console.WriteLine("sign = {0}, exponent = {1}, mantissa = {2}", sign, exponent, mantissa);

    }
}

