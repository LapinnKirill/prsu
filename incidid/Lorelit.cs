using System;

class Program
{
    static void SetTimeout(double timeout)
    {
        if (timeout > 0)
        {
            Console.WriteLine("Timeout set to " + timeout + " seconds");
        }
        else
        {
            throw new ArgumentException("Timeout must be a positive number greater than zero.");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            SetTimeout(5);       // This is valid
            SetTimeout(2.5);     // This is valid
            SetTimeout(-1);      // This will throw an exception
            SetTimeout(0);       // This will also throw an exception
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
