//  4.Write a program, that reads from the console an array of N integers and an integer K,
//  sorts the array and using the method Array.BinSearch() finds the largest number 
//  in the array which is ≤ K. 


using System;

class FindLargestElementSmallerThanKInMatrix
{

    static void PrintArrayInt(int[] arrInt)
    {
        for (int i = 0; i < arrInt.GetLength(0); i++)
        {
            Console.Write("{0} ", arrInt[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        //Console.Write("Input dimiension of matrix:");
        //int dimension = int.Parse(Console.ReadLine());
        //int[] arrayInt = new int[dimension];
        //for (int index = 0; index < arrayInt.Length; index++)
        //{
        //    Console.WriteLine("matrix[{0}}",index+1);
        //    arrayInt[index] = int.Parse(Console.ReadLine());
        //}
        int[] arrayInt = { 3, 4, -7, 81, 0, 6, 4, 8, 2 };
        PrintArrayInt(arrayInt);

        Array.Sort(arrayInt);
        PrintArrayInt(arrayInt);
        
        Console.Write("Input number K:");
        int numberK = int.Parse(Console.ReadLine());


        if (arrayInt[0] > numberK)
        {
            Console.WriteLine("Number K is too small");
        }
        else
        {
            int result = Array.BinarySearch(arrayInt, numberK);
            if (result > 0)
            {
                Console.WriteLine("Yes we have {0}, with index {1}",arrayInt[result],result);
            }
            else if(result<0)
            {
                Console.WriteLine("The largest number in array[]<=K is {0}",arrayInt[Math.Abs(result+2)]);
            }

        }
    }
}

