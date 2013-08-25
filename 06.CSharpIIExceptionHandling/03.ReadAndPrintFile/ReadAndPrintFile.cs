//  03.Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//  reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//  Be sure to catch all possible exceptions and print user-friendly error messages..


// Please create a text file somewhere in your HDD and input a correct name, or something else

using System;
using System.IO;

class ReadAndPrintFile
{
    public static string InputNameOfFile()
    {
        Console.Write("Input full file path name:");
        return(Console.ReadLine());
    }

    
    static void Main()
    {
        try
        {
            string fileContent = File.ReadAllText(InputNameOfFile());
            Console.WriteLine(fileContent);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Null reference!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Not name of file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directry is missing!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Too long path error!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        
    }
}

