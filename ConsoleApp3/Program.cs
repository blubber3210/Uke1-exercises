using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            //dag en 
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
            Console.WriteLine("The sum of your numbers is " + inputSum); */

            // if else
            // oppgave 1 - ta inn to tall og returnere true hvis de er like 
            /*
            int num1 = 3;
            int num2 = 4;
            bool isEqual = false;

            if (num1 == num2)
            {
                isEqual = true;
                Console.WriteLine("The numbers are equal");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("The numbers are not equal");
            }

            if (!isEqual)
            {
                Console.WriteLine("Try again! Enter a number");
                var input1 = Console.ReadLine();
                num1 = Convert.ToInt32(input1);
                Console.WriteLine("enter another number");
                var input2 = Console.ReadLine();
                num2 = Convert.ToInt32(input2);
                if (num1 == num2)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("too bad");
                }
            }
            */
            /*
            // oppgave 2 - pluss hvis tall er ulike/multiply hvis tall er like

            int sum = 0;

            Console.WriteLine("Let's see what happens if you enter two numbers that are equal or two numbers that are not.");
            Console.WriteLine("Enter first number");
            var input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            Console.WriteLine($"First number is {num1}! Enter second number");
            var input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);
            Console.WriteLine($"Your numbers are {num1} and {num2}");
            

            if (num1 == num2)
            {
                sum = num1 * num2;
            }
            else
            {
                sum = num1 + num2;
            }

            Console.WriteLine($"Sum is {sum}");
            */
            //oppgave 3 - to nummer, hvis sum eller en av de er 30 returnerer den true

            bool isThirty = false; 
            Console.WriteLine("Enter first number");
            var input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            Console.WriteLine($"First number is {num1}! Enter second number");
            var input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);
            int sum = num1 + num2; 

            Console.WriteLine($"Your numbers are {num1} and {num2}, the sum of which is {sum}");

            if (num1 + num2 == 30 || num1 == 30 || num2 == 30)
            {
                isThirty = true;
            }
            else
            {
                isThirty = false;
            }

            if (isThirty)
            {
                Console.WriteLine("something here is thirty");
            }
            else
            {
                Console.WriteLine("nothing here is thirty");
            }
        }
    }
}
