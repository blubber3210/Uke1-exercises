using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class OverloadExample
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        // default verdi: 

        public int LeggSammen(int tall1 = 2, int tall2 = 3)
        {
            return tall1 + tall2;
        }
    }
}
