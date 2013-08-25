//  10.Write a program to calculate n! for each n in the range [1..100]. 
//  Hint: Implement first a method that multiplies a number represented 
//  as array of digits by given integer number. 


using System;

class Factorial
{
    static void Main()
    {
        int[] factorial = { 1 };
       // here you can change factorial
        for (int i = 1; i <= 25; i++)
        {
            Console.Write("{0}!=",i);
            PrintArray(factorial = MultiplayArrays(factorial, i));
        }


    }
    // method from exercise 8
    static int[] SumArrays(int[] firstArray, int[] secondtArray)
    {
        
        // first have to be smaller array
        if (firstArray.Length>secondtArray.Length)
        {
            return SumArrays(secondtArray, firstArray);   
        }
        int[] sumArray = new int[secondtArray.Length + 1];

        sumArray[0] = 0;
        // for part where  two arrays have members
        for (int i = 0; i < firstArray.Length; i++)
        {
            sumArray[i] += firstArray[i] + secondtArray[i];
            if (sumArray[i] > 9)
            {
                sumArray[i] %= 10;
                sumArray[i + 1] = 1;
            }
        }
        //here we use only input number with more digits
        for (int i = firstArray.Length; i < secondtArray.Length; i++)
        {
            sumArray[i] += secondtArray[i];
            if (sumArray[i] > 9)
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

    static void PrintArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]); 
        }
        Console.WriteLine();
    }

    //  x*3=x*x*x
    static int[] MultiplayArrays(int[] x, int y)
    {
        int[] result = { 0 };
        for (int i = 0; i < y; i++)
        {
            result = SumArrays(result, x);
        }
        return result;
    }
}

