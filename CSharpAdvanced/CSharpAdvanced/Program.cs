using System.Text.RegularExpressions;
using System;

namespace CSharpAdvanced
{

    enum Day { Mo, Tu, We, Th, Fr, Sa, Su };
    enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;

        }

        public void Display()
        {
            Console.WriteLine($"Game 1's name is {name}, developed by {developer}, rated {rating} and released on {releaseDate}.");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            if(args.Length == 0 )
            {
                Console.WriteLine("This is a smart app that uses args ;), Please provide arguments next time. Pass help if you want to get more details");
                Console.ReadKey();
            }


            if (args[0] == "help")
            {
                //display manual
                Console.WriteLine("******************Instructions:");
                Console.WriteLine("* use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' to subtract 2 numbers");
                Console.WriteLine("*******************");

                Console.ReadKey();
                return;
            }

            if(args.Length != 3)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                Console.ReadKey();
                return;
            }

            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            if(!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                Console.ReadKey();
                return;
            }

            float result;

            switch(args[0].ToLower())
            {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"the sum of {num1} and {num2} is {result}");
                    break;
                case "sub":
                    result = num1 - num2;
                    Console.WriteLine($"The sub of {num1} and {num2} is {result}");
                    break;
                default:
                    Console.WriteLine("Invalid arguments, please use the help command for instructions");
                    break;
            }


            Console.ReadKey();
            //Nullables
            /*
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if(isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            double? num5 = 13.11;
            double? num6 = null;
            double num7;

            if(num5 == null)
            {
                num7 = 0.0;
            }
            else
            {
                num7 = (double)num5;
            }

            Console.WriteLine("Value of num8 is {0}", num7);

            num7 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num7);
            Console.WriteLine("Our nullable numbers are: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("The nullable bool value is {0}", boolval);

            Console.ReadKey();
            */
            //DATETIME
            DateTime dateTime = new DateTime(1988, 5, 31);

            Console.WriteLine("My birthday is on {0}", dateTime);

            DateTime now = DateTime.Now;
            

            Console.WriteLine("Today is {0}", now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be {0}", tomorrow);

            Console.WriteLine("First day of year: ");
            Console.WriteLine(GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);

            Console.WriteLine("Days in Feb 2000: {0}", days);

            days = DateTime.DaysInMonth(2001, 2);

            Console.WriteLine("Days in Feb 2001: {0}", days);

            days = DateTime.DaysInMonth(2004, 2);

            Console.WriteLine("Days in Feb 2004: {0}", days);

            DateTime now2 = DateTime.Now;

            Console.WriteLine("Minute : {0}", now2.Minute);

            Console.WriteLine("{0} o'clock {1} minutes {2} seconds", now2.Hour, now2.Minute, now2.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now2.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }


            Console.ReadKey();

            string input2 = System.IO.File.ReadAllText(@"C:\Projects\input2.txt");
            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);

            MatchCollection textCollection = regex.Matches(input2);

            foreach (Match hit in textCollection)
            {
                GroupCollection group = hit.Groups;
                int number = int.Parse(group[0].Value);
                char letter = (char)number;
                Console.WriteLine(letter);
            }

            Console.ReadKey();
            //string[] lines = { "First 250", "Second 242", "Third 240"};

            //File.WriteAllLines(@"C:\Projects\Assets\highscores.txt", lines);

            /*
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter text for a file");
            string input = Console.ReadLine();

            File.WriteAllText(@"C:\Projects\Assets\" + fileName + ".txt", input);
            */

            /*
            using (StreamWriter file = new StreamWriter(@"C:\Projects\Assets\myText.txt"))
            {
                foreach(string line in lines)
                {
                    if(line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Projects\Assets\myText2.txt", true))
            {
                file.WriteLine("Additional line");
            }
            */
            /*
            string text = System.IO.File.ReadAllText(@"C:\Projects\Assets\textFile.txt");

            Console.WriteLine("Text file contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Projects\Assets\textFile.txt");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */

            /*
            Console.WriteLine("Hello world!");

            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection mathCollection = regex.Matches(text);

            Console.WriteLine("{0} hits found: \n {1}", mathCollection.Count, text);

            foreach(Match hit in mathCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            Console.ReadKey();
            */
            /*
            Random dice = new Random();
            int numEyes;

            for(int i =0; i<10; i++)
            {
                numEyes = dice.Next(1,6);
                Console.WriteLine(numEyes);
            }

            Random yesNoMaybe = new Random();

            int answerNum;
            answerNum = yesNoMaybe.Next(1, 4);

            if(answerNum == 1)
            {
                Console.WriteLine("Yes");
            }
            else if(answerNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            Console.WriteLine("Floor: " + Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3, 5));
            Console.WriteLine("Pi is {0}", Math.PI);

            Console.WriteLine("the square root of 25 is {0}", Math.Sqrt(25));
            Console.WriteLine("Always positive is {0} ", Math.Abs(-25));

            Console.WriteLine("Cos of 1 is: {0}", Math.Cos(1));

            Console.ReadKey();
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine((int)Month.Feb);

            Console.ReadKey();
            Game game1;
            game1.name = "The Witcher 3";
            game1.developer = "CD Projekt Red";
            game1.rating = 9.2;
            game1.releaseDate = "01.07.2016";

            game1.Display();

            Console.ReadKey();
            */

        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
