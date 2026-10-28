using System;

class Program
{
    static void Main(string[] args)
    {
        // Problems 4
        // Read valid numbers using a method in the calculator.
        string choise = string.Empty;
        do
        {
            int fnum = ReadNumber("Please enter a first number. ");
            int snum = ReadNumber("Please enter a second number. ");
            Console.WriteLine("+ is addition. ");
            Console.WriteLine("- is subtraction. ");
            Console.WriteLine("* is multiplication. ");
            Console.WriteLine("/ is division. ");
            Console.WriteLine("0 is. exit");
            Console.Write("Please enter the calculation method. ");
            choise = Console.ReadLine();
            switch (choise)
            {
                case "+":
                    Console.WriteLine($"{fnum} + {snum} = {fnum + snum}");
                    break;

                case "-":
                    Console.WriteLine($"{fnum} - {snum} = {fnum - snum}");
                    break;

                case "*":
                    Console.WriteLine($"{fnum} * {snum} = {fnum * snum}");
                    break;

                case "/":
                    if (snum == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed. ");
                    }
                    else
                    {
                        Console.WriteLine($"{fnum} / {snum} = {(double)fnum / snum:F2}");
                    }
                    break;

                case "0":
                    break;
            }

        } while (choise != "0");
    }

    static int ReadNumber(string question)
    {
        int number;
        Console.Write(question);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter a valid number.");
            Console.Write(question);
        }
        return number;
    }
}
