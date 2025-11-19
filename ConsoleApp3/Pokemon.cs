using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Pokemon
    {
        public string Name;
        public int Health;
        public int Level;

        public Pokemon(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }
    }
}
