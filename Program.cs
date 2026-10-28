using System;

class Program
{
    static void Main(string[] args)
    {
        // Problems 2
        // Check even numbers and find the larger of two numbers.
        Console.WriteLine(IsEven(2));
        Console.WriteLine(IsEven(7));
        Console.WriteLine(IsEven(12));

        Console.WriteLine(Max(3, 8));
        Console.WriteLine(Max(10, 4));
        Console.WriteLine(Max(6, 6));
    }

    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    static int Max(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
