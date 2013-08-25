//  6.Write a method that returns the index of the first element in array 
//  that is bigger than its neighbors, or -1, if there’s no such element.
//  Use the method from the previous exercise.


using System;

class FindFirstElementBiggerThanNeighbors
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

        if (index == 0)
        {
            return (arrInt[index] > arrInt[index + 1]);
        }
        else if (index == arrInt.Length - 1)
        {
            return (arrInt[index] > arrInt[index - 1]);
        }
        else
        {
            return (arrInt[index - 1] < arrInt[index] && arrInt[index + 1] < arrInt[index]);
        }

    }


     static int FindFirstIndexWhithSmallerNeighbors(int[] arrInt)
    {
         for (int i = 0; i < arrInt.Length; i++)
        {
            if (CheckNeighborElements(arrInt, i))
            {
                return i;
            } 
        }
         return -1;
    }


    static void Main()
    {
        int[] arrayInt = { 4, 5, 6, 66, -2, 96, 99, 100, 109, 110, 234 };
        PrintVektor(arrayInt);
        int result=FindFirstIndexWhithSmallerNeighbors(arrayInt);
        Console.WriteLine("The first member in array that is \n bigger than its neighbours is {0} with index {1}",arrayInt[result], result);
       

    }

  
}

