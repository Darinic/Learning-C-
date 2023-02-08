using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //this class is a  blueprint for a datatype
    internal class Human
    {
        //member variable
        public string firstName;
        public string lastName;
        public int age;
        public string eyeColor;

        public Human()
        {
            Console.WriteLine("Constructer called.Object created");
        }


        // constructor
        public Human(string firstName, string lastName, int age, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        //member
        public void IntroduceMyself()
        {
            {
                if (age != 0)
                {
                    Console.WriteLine($"Hi, I am {firstName} {lastName}, I am {age} years old and my Eye color is {eyeColor}");
                }
                else
                {
                    Console.WriteLine($"Hi, I am {firstName} {lastName} and my Eye color is {eyeColor}");
                }
            }
        }
    }
}
