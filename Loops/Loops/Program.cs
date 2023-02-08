// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while(input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 when you are ready to calculate the average");

                input = Console.ReadLine();
                if(input == "-1")
                {
                    Console.WriteLine("------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("the average score of your students is {0}", average);
                }
                if(int.TryParse(input, out currentNumber) && currentNumber >0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if(!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }
                count++;
            }

            for(int counter = 0; counter <10; counter++)
            {       
                    Console.WriteLine($"Hello World! {counter}");
            }

            int counter1 = 0;
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
                //Console.WriteLine(counter1);
                //counter1++;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enough");
        }
    }
}
