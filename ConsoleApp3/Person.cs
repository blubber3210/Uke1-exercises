using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor: 

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
