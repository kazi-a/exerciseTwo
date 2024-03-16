using System;

namespace Assignment8ex2
{
    public delegate void CustomDelegate(double a, double b);

    public class MathSolutions
    {
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }

        public static void ActionDelegate(double a, double b)
        {
            Console.WriteLine($"Action Delegate: {a} + {b} = {a + b}");
        }

        static void Main(string[] args)
        {
            // Create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            // Print the sum of two numbers
            Console.WriteLine($" {num1} + {num2} = {answer.GetSum(num1, num2)}");

            // Create a Func delegate for GetProduct method
            Func<double, double, double> funcDelegate = answer.GetProduct;
            double product = funcDelegate(num1, num2);
            Console.WriteLine($"Using Func delegate: {num1} * {num2} = {product}");

            // Print the smaller number
            answer.GetSmaller(num1, num2);

            // Execute the Action delegate
            Action<double, double> actionDelegate = ActionDelegate;
            actionDelegate(num1, num2);

            // Execute the custom delegate
            CustomDelegate customDelegate = answer.GetSmaller;
            customDelegate(num1, num2);
        }
    }
}
