// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;

namespace CConditions
{
    class Program
    {
        static string username;
        static string password;

        static int highscore = 300;
        static string highscorePlayer = "Denis";
        static int temperature;
        static void Main(string[] args)
        {
            string result;
            Console.WriteLine("Enter temperature: ");
            try{
                temperature = Convert.ToInt32(Console.ReadLine());
                result = temperature <= 15 ? "It is cold here" : (temperature > 28 ? "It is too hot here" : "It is ok");
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Not a valid temperature");
            }

            Console.Read();

            /*int temperature = 2;
            string stateOfMatter;

            if(temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            }
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature -= 30;

            stateOfMatter = temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.Read();
            

            CheckHighscore(299, "Vadim");
            CheckHighscore(315, "Michael");
            CheckHighscore(350, "Denis");

            Console.Read();
            */


            /*int age = 18;

            switch(age)
             {
                 case <18:
                     Console.WriteLine("To young to party in the club");
                     break;
                 case >= 18:
                         Console.WriteLine("Good to go!");
                         break;
                 default:
                     Console.WriteLine("What are you?");
                     break;
             }
             Console.Read();

             Register();
             Login();
             Console.Read();
            */

            // bool isAdmin = false;
            // bool isRegistered = true;
            // string userName = "";
            // Console.WriteLine("Please enter your username");

            // userName = Console.ReadLine();
            // if (isRegistered && userName != "" && userName.Equals("admin"))
            //  {
            //  Console.WriteLine("Hi there registered user");

            //  Console.WriteLine("Hi there, " + userName);

            //  Console.WriteLine("Hi there Mr. Admin");  
            // }

            // if(isAdmin || isRegistered)
            // {
            //   Console.WriteLine("You are logged in");
            // }
            // Console.Read();

            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            
            Console.WriteLine("Enter what is the temperature outside: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp < 10)
            {
                Console.WriteLine("Take the coat");
            }
            else if(temp ==10)
            {
                Console.WriteLine("It's 10 degrees C");
            }
            else
            {
                Console.WriteLine("It's warm");
            }

            

            //

            string numberAsString = "128x";
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue);

            if(success)
            {
                Console.WriteLine("Parsing successful - number is " + parsedValue);
        }
            else
            {
                Console.WriteLine("Parsing failed");
            }
        }
        public static void Register()
        {
            Console.WriteLine("Please enter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("You are logged in");
                }
                else
                {
                    Console.WriteLine("Login failed, incorrect password. Restart program.");
                }
            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart program.");
            }
        }
        public static void CheckHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine($"New highscore is {score}");
                Console.WriteLine($"It is now held by {playerName}");
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still held by" + highscore + " and held by " + highscorePlayer);
            }
        }
    }
}