// See https://aka.ms/new-console-template for more information
namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteSomething();
            //WriteSomethingSpecific("I am an argument!");
            //int result = Add(15, 31);
            //Console.WriteLine(result);
            //Console.WriteLine(Divide(25, 13));
            //Console.Read();

            //string friend1 = "Frank";
            //string friend2 = "Michael";
            //string friend3 = "Wlad";

            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);

            //User input
            //Calculate();
            //Console.Read();


            //
            //Console.WriteLine("Please enter a number!");
            //string userInput = Console.ReadLine();

            //try
            //{
            // int userInputAsInt = int.Parse(userInput);
            //}
            //catch (FormatException)
            //{
            //Console.WriteLine("Format exception, please enter the correct type next time :) ");
            //}
            //catch (OverflowException)
            //{
            //Console.WriteLine("Overflow Exception, the number was too short or too long for int32");
            //}
            //catch (ArgumentNullException)
            //{
            //Console.WriteLine("Argument Null Exception, the value was empty :) ");
            //}
            //finally
            //{
            //Console.WriteLine("This is called anyways!");
            //}
            //Console.ReadKey();

            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operators

            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
        }
        //access modifier (static) return type method name (parameter1, parameter2)
        
        public static void Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);

            int result = num1 + num2;
            Console.WriteLine(result);
        }
        
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
           
        }

        public static int Multiply(int parameter1, int parameter2)
        {
            return parameter1 * parameter2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine($"Hi {friendName}, my friend!");
        }
    }
    
}

namespace Coding.Exercise
{
    public class Method
    {
        public static string LowUpper(string text)
        {
            return text.ToLower() + text.ToUpper();
        }
        public static void Count(string text)
        {
            Console.WriteLine($"The amount of characters in the string is : {text.Length}");
        }


        public static void Run()
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);

        }
    }
}



