using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            long longNum = 23;
            float decimalNum1 = 1.5F;
            decimal decimalNum2 = 2.4M;
            double decimalNum3 = 1.4;
            string text = "this is a text";
            char letter = 'a';
            bool trueOrFalse = true;

            int a = 4;
            decimal b = 2;
            decimal sum = a + b;

            Console.WriteLine("Enter first number:");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter second number");
            var input2 = Console.ReadLine();
            int input1converted = Convert.ToInt32(input1);
            int input2converted = Convert.ToInt32(input2);
            int inputSum = input2converted + input1converted;
            Console.WriteLine("The sum of your numbers is " + inputSum);
        }
    }
}
