//  8.Write a method that adds two positive integer numbers represented as arrays of digits 
//  (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//  Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Collections.Generic;

class SumTwoNumbersAsArrays
{
    static Random generator = new Random();

    static void Main()
    {
        Console.Write(" first number=");
        string firstString = Console.ReadLine();
        int[] firstArray = StringToArray(firstString);

        Console.Write("second number=");
        string secondString = Console.ReadLine();
        int[] secondArray = StringToArray(secondString);

        // uncomment this in case of using arrays generation

        //Console.WriteLine("Size of first array to generate:");
        //int sizeFirstArray = int.Parse(Console.ReadLine());
        //int[] firstArray = new int[sizeFirstArray];
        //GenerateArray(firstArray);
        //PrintArray(firstArray);
        

        //Console.WriteLine("Size of second array to generate:");
        //int sizeSecondArray = int.Parse(Console.ReadLine());
        //int[] secondArray = new int[sizeSecondArray];
        //GenerateArray(secondArray);
        //PrintArray(secondArray);

        //reversed numbers
        int[] tempFirst = ReverseArray(firstArray);
        int[] tempSecond = ReverseArray(secondArray);

        // allways array with smaller length is first
        int[] resultArray;
        if (firstArray.Length<secondArray.Length)
        {
            resultArray = SumArrays(tempFirst, tempSecond);
        }
        else
        {
            resultArray = SumArrays(tempSecond, tempFirst);
        }
        Console.WriteLine("Result is:");
        PrintArray(ReverseArray(resultArray));

    }

    static int[] SumArrays(int[] firstArray, int[] secondtArray)
    {
        int[] sumArray=new int[secondtArray.Length+1];

        sumArray[0]=0;
        // for part where  two arrays have members
        for (int i = 0; i < firstArray.Length; i++)
        {
            sumArray[i] += firstArray[i] + secondtArray[i];
            if (sumArray[i]>9)
            {
                sumArray[i] %= 10;
                sumArray[i + 1] = 1;
            }
        }
        //here we use only input number with more digits
        for (int i = firstArray.Length; i < secondtArray.Length; i++)
        {
            sumArray[i] += secondtArray[i];
            if (sumArray[i]>9)
            {
                sumArray[i] %= 10;
                sumArray[i + 1] = 1;
            }
        }

        if (sumArray[sumArray.Length - 1] == 0)
        {
            Array.Resize(ref sumArray, sumArray.Length - 1);
        }
        return sumArray;
    }
    // fill array whith custom length
    static void GenerateArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = generator.Next(0, 10);
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (int index in arr)
        {
            Console.Write("{0}", index);
        }
        Console.WriteLine();
    }
   
    
    static int[] ReverseArray(int[] array)
    {
        int[] temp = new int[array.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = array[array.Length - 1 - i];
        }
        return temp;
    }
    // convert input number(string) to a array
    static int[] StringToArray(string strNumber)
    {
        int[] arrInt = new int[strNumber.Length];
        for (int i = 0; i < arrInt.Length; i++)
        {
            arrInt[i] = strNumber[i]-48;
        }
        return arrInt;
    }
}

