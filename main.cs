using System;

class SimpleCalculator
{
    static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Simple Arithmetic Calculator");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformOperation("Addition", (a, b) => a + b);
                    break;
                case "2":
                    PerformOperation("Subtraction", (a, b) => a - b);
                    break;
                case "3":
                    PerformOperation("Multiplication", (a, b) => a * b);
                    break;
                case "4":
                    PerformDivision();
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose a number from 1 to 5.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void PerformOperation(string operationName, Func<double, double, double> operation)
    {
        double a = GetNumber("Enter the first number (a): ");
        double b = GetNumber("Enter the second number (b): ");
        double result = operation(a, b);
        Console.WriteLine($"{operationName} result: {result}");
    }

    static void PerformDivision()
    {
        double a = GetNumber("Enter the first number (a): ");
        double b = GetNumber("Enter the second number (b): ");
        
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed. Please enter a non-zero divisor.");
        }
        else
        {
            double result = a / b;
            Console.WriteLine($"Division result: {result}");
        }
    }

    static double GetNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
