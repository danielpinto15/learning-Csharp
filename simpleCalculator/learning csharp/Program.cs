using System;

namespace learning_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case"+":
                    Console.Write(num1 + num2);
                    break;
                case "-":
                    Console.Write(num1 - num2);
                    break;
                case "*":
                    Console.Write(num1 * num2);
                    break;
                case "/":
                    Console.Write(num1 / num2);
                    break;
                default:
                    Console.Write("Invalid Operator");
                    break;
            }

            Console.ReadLine();
        }
        
    }
}
