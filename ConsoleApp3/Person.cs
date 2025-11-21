using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // Constructor: 

        public Person(string name)
        {
            Name = name;
        }


        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        

    }
}
