//  2.Write a program that generates and prints to the console 
//  10 random values in the range [100, 200].


using System;

class GenerateTenRandomValues100To200
{

    static Random randomGenerator = new Random();


    static void Main()
    {

        int numbers = 10;
        int start=100;
       int end=200;
        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine(randomGenerator.Next(start, end + 1));    
        }
    }
}

