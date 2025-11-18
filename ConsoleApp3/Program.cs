using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Samlet moodle oppgaver, kommentert ut løpende 
            //dag en 
            /*

            ------------------------------------------------------
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


            // oppgave 2 - pluss hvis tall er ulike/multiply hvis tall er like
            /*--------------------------------------------------------

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
            /*------------------------------------------------------------

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

            */


            //Random
            // oppgave: random hobby generator. Forsøk 1 - uten array 
            /*
            var rand = new Random();
            string name = "Noname";

            Console.WriteLine("What's the name?");
            name = Console.ReadLine();
            var randomNum = rand.Next(0, 3);
            if (randomNum == 0)
            {
                Console.WriteLine($"{name}'s new hobby is skiing");
            } else if (randomNum == 1)
            {
                Console.WriteLine($"{name}'s new hobby is climbing");
            } else 
            {
                Console.WriteLine($"{name}'s new hobby is dancing");
            }

            */


            //Switch
            //oppgave 1 - ukedager
            /*

            Console.WriteLine("enter a number between 1 and 7");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("mandag");
                    break;

                case "2":
                    Console.WriteLine("tirsdag");
                    break;

                case "3":
                    Console.WriteLine("onsdag");
                    break;

                case "4":
                    Console.WriteLine("torsdag");
                    break;

                case "5":
                    Console.WriteLine("fredag");
                    break;

                case "6":
                    Console.WriteLine("lørdag");
                    break;

                case "7":
                    Console.WriteLine("søndag");
                    break;

                default:
                    Main(args);
                    break;
            }

            // TestSomething();Still doesn't work 

            */

            //Loops
            //For loop test 

            string[] texts = new string[] { "this", "is", "fun" };
            
            for (int i = 0; i < texts.Length; i++)
            {
                Console.WriteLine(texts[i]);
            }
            

            foreach (var text in texts)
            {
                Console.WriteLine(text);
                
            }
        }

    }
}
