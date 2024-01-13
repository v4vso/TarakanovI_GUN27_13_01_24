using System;

class Program
{
    static void Main(string[] args)
    {
        //First number check
        Console.Title = "CalculatorApp";

        Console.WriteLine("Please enter first number:");
        if (!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Error! Not a number");
            return;
        }
        Console.WriteLine("Please enter second number:");

        //Second number check

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Error! Not a number");
            return;
        }
        Console.WriteLine("Enter a logical operator (+ - * / % & | ^)");
        var userInput = Console.ReadLine();

        //Error sign check

        if (userInput != null && userInput.Length is 0 or > 1)
        {
            Console.WriteLine("Error! Wrong sign");
            return;
        }

        //Logical operations

        switch (userInput[0])
        {
            case '+':
                Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
                break;
            case '-':
                Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
                break;
            case '*':
                Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
                break;
            case '/':
                Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
                break;
            case '%':
                Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
                break;
            case '&':
                Console.WriteLine("Decimal system (10): Result of {0} & {1} = {2} ", a, b, Convert.ToString(a & b, 10));
                Console.WriteLine("Binary system (2):  Result of {0} & {1} = {2} ", a, b, Convert.ToString(a & b, 2));
                Console.WriteLine("Hexadecimal system (16): Result of {0} & {1} = {2} ", a, b, Convert.ToString(a & b, 16));
                break;
            case '|':
                Console.WriteLine("Decimal system (10): Result of {0} | {1} = {2} ", a, b, Convert.ToString(a | b, 10));
                Console.WriteLine("Binary system (2): Result of {0} | {1} = {2} ", a, b, Convert.ToString(a | b, 2));
                Console.WriteLine("Hexadecimal system (16): Result of {0} | {1} = {2} ", a, b, Convert.ToString(a | b, 16));
                break;
            case '^':
                Console.WriteLine("Decimal system (10): Result of {0} ^ {1} = {2} ", a, b, Convert.ToString(a ^ b, 10));
                Console.WriteLine("Binary system (2): Result of {0} ^ {1} = {2} ", a, b, Convert.ToString(a ^ b, 2));
                Console.WriteLine("Hexadecimal system (16): Result of {0} ^ {1} = {2} ", a, b, Convert.ToString(a ^ b, 16));
                break;
            default:
                Console.WriteLine("Error! Wrong sign");
                break;
        }
    }
}