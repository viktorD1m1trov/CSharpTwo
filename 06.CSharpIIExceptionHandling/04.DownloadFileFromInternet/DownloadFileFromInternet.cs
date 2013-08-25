//  04.Write a program that downloads a file from Internet
//  (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores 
//  it the current directory. Find in Google how to download 
//  files in C#. Be sure to catch all exceptions and to free any
//  used resources in the finally block.


using System;
using System.Net;

class DownloadFileFromInternet
{
    static void Main()
    {
        try
        {
            // Downloads the resource with the specified URI to a local file with a given name,
            //  usually in your current working directory (project\bin\Debug)

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(" http://www.devbg.org/img/Logo-BASD.jpg", "LogoBASD3.jpg");
                Console.WriteLine("Downloaded");
            }
        }
        catch (WebException)
        {
            Console.WriteLine("An error occurred while trying to download the file! Make sure the url is valid, the file you want to download exists and the internet connection is running!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("No URL Address! ");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The DownloadFile method cannot be called simultaneously on multiple threads.");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }

    }
}

