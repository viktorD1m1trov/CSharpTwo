//  5.Write a method that checks if the element at given position in given
//  array of integers is bigger than its two neighbors (when such exist).
using System;

class ChekTheNeighbors
{
    static void PrintVektor(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }


     static bool CheckNeighborElements(int[] arrInt, int index)
    {
        
         if (index==0)
        {
            return(arrInt[index]>arrInt[index+1]);
        }
        else if (index==arrInt.Length-1)
        {
            return (arrInt[index] > arrInt[index - 1]);
        }
        else
        {
            return (arrInt[index - 1] < arrInt[index] && arrInt[index +1] < arrInt[index]);
        }
         
    }


    static void Main()
    {
        int[] arrayInt = { 9, 8, 5, 6, -2, 96, -3, 5, -9, 0, 234 };
        PrintVektor(arrayInt);

        Console.WriteLine("Input index from 0 to {0} in array to check its neighbors",arrayInt.Length-1);
        int index=int.Parse(Console.ReadLine());
        Console.WriteLine("Are neighbirs smaller? {0}", CheckNeighborElements(arrayInt, index));

    }
  
    
}

