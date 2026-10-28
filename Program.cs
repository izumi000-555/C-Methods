using System;

class Program
{
    static void Main(string[] args)
    {
        // Problems 3
        // Convert Celsius to Fahrenheit and count vowels in a sentence.
        Console.Write("Please enter the temperature in Celsius: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Fahrenheit: {CelsiusToFahrenheit(c):F1}");

        Console.Write("Please enter the English text: ");
        string text = Console.ReadLine();
        Console.WriteLine($"Number of vowels: {CountVowels(text)}");
    }

    static double CelsiusToFahrenheit(double c)
    {
        return c * 9 / 5 + 32;
    }

    static int CountVowels(string text)
    {
        int count = 0;
        foreach (char letter in text.ToLower())
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                count++;
            }
        }
        return count;
    }
}
