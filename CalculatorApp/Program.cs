using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = PerformOperation(num1, num2, operation);

        Console.WriteLine($"Result: {result}");

        Console.ReadLine(); // Keep console window open
    }

    static double PerformOperation(double x, double y, char op)
    {
        switch (op)
        {
            case '+':
                return Add(x, y);
            case '-':
                return Subtract(x, y);
            case '*':
                return Multiply(x, y);
            case '/':
                return Divide(x, y);
            default:
                Console.WriteLine("Invalid operation");
                return 0;
        }
    }

    static double Add(double x, double y)
    {
        return x + y;
    }

    static double Subtract(double x, double y)
    {
        return x - y;
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static double Divide(double x, double y)
    {
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
    }
}
