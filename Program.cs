using System;
class Program
{
    static void Main(string[] args)
    {
        // Problems 1
        // Print a line of 20 '-' characters three times.
        PrintLine();
        PrintLine();
        PrintLine();
    }

    static void PrintLine(int length = 20)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}
