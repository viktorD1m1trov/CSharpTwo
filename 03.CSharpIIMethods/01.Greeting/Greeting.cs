
//  1.Write a method that asks the user for his name and prints “Hello, <name>” 
//  (for example, “Hello, Peter!”). Write a program to test this method.


using System;

class Greeting
{
    static void GreetYou()
    {
        Console.WriteLine("Hi. What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",yourName);
    }

    static void Main()
    {
        GreetYou();

    }
}

