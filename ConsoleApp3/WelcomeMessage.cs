using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class WelcomeMessage
    {
       
        public void PrintWelcomeMessage(string compliment = "Du er fin")
        {
            Console.WriteLine("Hei og velkommen. " + compliment);
        }
    }
}
