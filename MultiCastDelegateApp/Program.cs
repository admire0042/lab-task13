using System;

namespace MultiCastDelegateApp
{
    class Program
    {
        public delegate void MyDel(double a, double b);
        static void Main(string[] args)
        {
            MyDel mydel = Addition;
            mydel += Multiplication;

            Console.WriteLine("Please enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            mydel(num1,num2);
            
        }

        static void Addition(double num1, double num2)
        {
            double sum = num1 + num2;
            Console.WriteLine($"The addition of the two numbers is: {sum}");
        }

        static void Multiplication(double num1, double num2)
        {
            double multi = num1 * num2;
            Console.WriteLine($"The multiplication of the two numbers is: {multi}");
        }
    }
}
