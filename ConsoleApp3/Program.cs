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

            ////////////////////////////////////////////////////////////////////////////
            ///////////////////////////// Grunnleggende C# //////////////////////////////
            ////////////////////////////////////////////////////////////////////////////
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
            // For: Når vi vil gjenta noe et spesifikt antall ganger eller behøver en indeks for å prosessere dataene våre
            // Foreach: Når vi ikke er opptatt av hvilken index eller hvor mange ganger noe skal gjøres, men heller vil gjøre noe per element 
            // While: Brukes når man vil utføre en handling så lenge en "condition" har boolean verdien "true" 
            
            //For loop test 

            //string[] texts = new string[] { "this", "is", "fun" };
            
            /*
            for (int i = 0; i < texts.Length; i++)
            {
                Console.WriteLine(texts[i]);
            }
            */

            /*
            foreach (var text in texts)
            {
                Console.WriteLine(text);
            }
            */

            /*
            bool condition = true;
            int i = 0;
            while (condition)
            {
                if (i < 10)
                {
                    Console.WriteLine("elida er kul");
                    i++;
                }
                else
                {
                    condition = false;
                }
            }
            */

            // oppgave 1: lag en for løkke som printer ut "Terje er kul" 5 ganger
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Terje er kul");
            }
            */
            // oppgave 2: foreach løkke som printer ut hver bokstav i en string og printer i konsollen
            /*
            string word = "Crocodile";
            foreach (var letter in word)
            {
                Console.Write(letter);
            }
            */
            // oppgave 3: while løkke som printer ut "rundenummer" pluss et tall opptil ti runder
            /*
            bool condition = true;
            int round = 1;
            while (condition)
            {
                if (round < 10)
                {
                    Console.WriteLine($"Runde nummer {round}");
                    round++;
                }
                else
                {
                    condition = false;
                }
            }
            */

            // oppgave: Krokodillespill
            // CrocodileGame();
            
            // oppgave: TekstTukling
            // ChangeText();

            // oppgave: gjett tallet
            // GuessNumber();

            // oppgave: hva gjør koden? 
            // WhatDoesThisCodeDo();

            ///////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////// Intro til objektorientering //////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////
            ///
            
            // Oppgave: pokedex
            // PrintPokemon();

            // Objekter i liste
            // AddPeople();

            // METHOD OVERLOADING 
            //// **
            //OverloadExample calculator = new OverloadExample();
            //Console.WriteLine("Sum med to int-parametre: " + calculator.Add(1,10));
            //Console.WriteLine("Sum med tre int-parametre: " + calculator.Add(1,10, 5));
            //Console.WriteLine("Sum med to double-parametre: " + calculator.Add(2.5, 1.7));
            
            // default values 
            // default verdi er verdien en ny variabel får hvis du ikke gir den en annen verdi.
            // hvis man ikke sender inn noe verdi som peramater, vil metoden fremdeles lese koden med default verdien
            // eksempel: 

            //int sum = calculator.LeggSammen();
            //Console.WriteLine("Summen er: " + sum);
            //int sum2 = calculator.LeggSammen(5, 5);
            //Console.WriteLine("Summen er: " + sum2);








        }

        static void CrocodileGame()
        {
            /*
             *For hver runde skal det printes ut til skjermen et random tall mellom 1-11, et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5
               
               Brukeren kan skrive inn <, > eller =
               
               i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5
               
               Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
               Det må verifiseres om brukeren har valgt riktig alternativ.
               Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
               Poengsummen printes til skjermen for hvert svar brukeren har gitt.
               Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene
             */
            int points = 0;
            string[] validInputs = { "=", "<", ">" };
            var rand = new Random();

            while (true)
            {
                int num1 = rand.Next(1, 12);
                int num2 = rand.Next(1, 12);

                Console.WriteLine($"{num1} _ {num2}");
                Console.WriteLine("Type >, <, or = to continue");

                string input = Console.ReadLine();

                if (!validInputs.Contains(input))
                {
                    Console.WriteLine("Good game, good bye");
                    break;
                }

                string correctAnswer;

                if (num1 < num2) correctAnswer = "<";
                else if (num1 > num2) correctAnswer = ">";
                else correctAnswer = "=";

                if (input == correctAnswer)
                {
                    points++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Correct! You have {points} points");
                    Console.ResetColor();
                }
                else
                {
                    points--;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Incorrect! You lose a point :( You have {points} points");
                    Console.ResetColor();
                }

                Console.WriteLine();
                Thread.Sleep(600);
            }

        }

        static void ChangeText()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("let's do something with some text");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("what do you want to do? Type 1 or 2, then press enter");
            Console.WriteLine("1. rotate text \n 2. change text");
            Console.ResetColor();
            var menuSelect = Console.ReadLine();
            if (menuSelect == "1")
            {
                RunRotateText();
            }
            else if (menuSelect == "2")
            {
                RunChangeText();
            }
            else
            {
                Console.WriteLine("oops");
                Console.WriteLine();
                ChangeText();
            }
        }

        static void RunRotateText()
        {
            Console.WriteLine("Type a word");
            var input = Console.ReadLine();
            Console.WriteLine($"your word: {input}");

            char[] cArray = input.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            Console.WriteLine($"output: {reverse}");
        }

        static void RunChangeText()
        {
            Console.WriteLine("Type a word");
            var input = Console.ReadLine();
            Console.WriteLine($"Your word is {input}");

            char[] cArray = input.ToCharArray();
            char character = 'e';
            char newCharacter = 'a';
            string outputWord;

            if (cArray.Contains(character))
            {
                cArray.Replace(character, newCharacter);
                foreach (char letter in cArray)
                {
                    Console.Write(letter);
                }
            }
            else
            {
                RunChangeText();
            }
        }

        static void GuessNumber()
        {
            var rand = new Random();
            int randomNumber = rand.Next(1, 101);
            Console.WriteLine("Guess a number!");

            while (true)
            {
                var input = Console.ReadLine();

                if (!int.TryParse(input, out int inputNum))
                {
                    Console.WriteLine("please enter a valid number");
                    continue;
                }

                if (inputNum == randomNumber)
                {
                    Console.WriteLine("Correct! good bye");
                    break; 
                }
                else if (inputNum > randomNumber)
                {
                    Console.WriteLine("too big");
                    Console.WriteLine();
                }
                else 
                {
                    Console.WriteLine("too small");
                    Console.WriteLine();
                }
            }
        }

        static void WhatDoesThisCodeDo()
        {


            var range = 250;
            var counts = new int[range];
            int totalLetters = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in (text ?? string.Empty).ToLower())
                {
                    counts[(int)character]++;
                    totalLetters++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var percentage = 100 * (double)counts[i] / totalLetters;
                        string output = character + " - " + percentage.ToString("F2") + "%";
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                        Console.ResetColor();
                    }
                }
            }
        }

        static void PrintPokemon()
        {
            var pikachu = new Pokemon("Pikachu", 50, 21);
            //myPokemon.Name = "Pikachu";
            //myPokemon.Health = 50;
            //myPokemon.Level = 21;

            Console.WriteLine($"Name: {pikachu.Name} \nHealth: {pikachu.Health} \nLevel: {pikachu.Level}");

            var bulbasaur = new Pokemon("Bulbasaur", 40, 30);

            Console.WriteLine($"Name: {bulbasaur.Name} \nHealth: {bulbasaur.Health} \nLevel: {bulbasaur.Level}");

            /*
            Pokemon newPokemon = new Pokemon();

            Console.Write("Name: ");
            newPokemon.Name = Console.ReadLine();
            Console.Write("Health: ");
            newPokemon.Health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Level: ");
            newPokemon.Level = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name: {newPokemon.Name} \nHealth: {newPokemon.Health} \nLevel: {newPokemon.Level}");

            */
        }

        static void AddPeople()
        {
            List<Person> people = new List<Person>();

            Person person1 = new Person("Lise", 60);
            Person person2 = new Person("Karl", 30);
            Person person3 = new Person("Tomas", 42);

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);

            Console.WriteLine("Persons in list");

            foreach (Person person in people)
            {
                Console.WriteLine($"Navn: {person.Name}, Alder: {person.Age}");
            }
        }
    }
}
