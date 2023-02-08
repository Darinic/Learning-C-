using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        public virtual void MakeSound()
        {
            
        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} says: I'm hungry and I will eat now!");
            }
            else
            {
                Console.WriteLine($"{Name} says: I'm not hungry!");

            }
        }
         
        public virtual void Play()
        {
            Console.WriteLine($"{Name} says: I'm playing!");
            
        }
            
    }
}
