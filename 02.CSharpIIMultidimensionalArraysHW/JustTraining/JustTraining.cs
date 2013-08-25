using System;

class JustTraining
{
    static void Method(int[,] nums)
    {
        nums[0, 0] = 100;
    }
    
    
    
    static void Main()
    {
        

        int[] dimensions = { 0, 0, 0 };
        dimensions[0] = int.Parse(Console.ReadLine());
        dimensions[1] = int.Parse(Console.ReadLine());     
        dimensions[2] = int.Parse(Console.ReadLine());

        int[, ,] array = new int[dimensions[0],
                                dimensions[1],
                                dimensions[2]];

        for (int index1 = 0; index1 < array.GetLength(0); index1++)
        {
            for (int index2 = 0; index2 < array.GetLength(1); index2++)
            {
                for (int index3 = 0; index3 < array.GetLength(2); index3++)
                {
                    Console.Write("array [{0},{1},{2}]= ",index1,index2,index3);
                    array[index1, index2, index3] = int.Parse(Console.ReadLine());
                }
            }
        }

        for (int index1 = 0; index1 < array.GetLength(0); index1++)
        {
            for (int index2 = 0; index2 < array.GetLength(1); index2++)
            {
                for (int index3 = 0; index3 < array.GetLength(2); index3++)
                {
                    Console.Write(array[index1,index2,index3]+" " );

                }
                Console.WriteLine();
            }
        }

        Console.WriteLine(array.GetValue(3));
    }
}

