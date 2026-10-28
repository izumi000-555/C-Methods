using System;

class Program
{
    static void Main(string[] args)
    {
        // Problems 5
        // Print prime numbers from 1 to 100 and find the sum of digits.
        for (int i = 1; i <= 100; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Sum of digits: {SumOfDigits(number)}");
    }

    static bool IsPrime(int n)
    {
        if (n < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static int SumOfDigits(int n)
    {
        long number = Math.Abs((long)n);
        int sum = 0;

        while (number > 0)
        {
            sum += (int)(number % 10);
            number /= 10;
        }

        return sum;
    }
}
