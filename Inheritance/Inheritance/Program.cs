// See https://aka.ms/new-console-template for more information\
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        //1. IEnumerable <T> for generic collection
        //2 IEnumerable for non generic collection
        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numberQueue = new Queue<int>();

            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numberQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }

        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach(int num in anyCollection)
            {
                sum += num;
            }

            Console.Write("Sum is {0}", sum);
        }
        
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 8, 6, 2 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };

            CollectionSum(numberList);
            CollectionSum(numberArray);


            Console.ReadKey();

            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");

            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");

            unknownCollection = GetCollection(2);

            Console.WriteLine("This is a Queue<int>");

            foreach(int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("");

            unknownCollection = GetCollection(5);
            Console.WriteLine("This is a new int array");

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();

            
            DogShelter shelter = new DogShelter();
            foreach(BoostedDog dog in shelter)
            {
                if(!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }

            /*
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Console.WriteLine(t2.Equals(t1));

            Console.ReadKey();
            */

            /*
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car damagedCar = new Car(80f, "Blue");

            damagedCar.DestroyableNearby.Add(officeChair);
            damagedCar.DestroyableNearby.Add(gamingChair);

            damagedCar.Destroy();
            */

            /*
            Employee michael = new Employee("Michael", "Scott", 75000);
            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 999999999);
            chuckNorris.Lead();

            Trainee michaele = new Trainee(40, 20, "Michael", "Scott", 75000);
            michaele.Work();
            michaele.Learn();

            Console.ReadKey();
            */

            /*
            Post post1 = new Post("Thanks for the birthday wishes", true, "Daniil Arinic");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("check out my new Shoes", "Daniil Arinic", "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("Check out my new video", "Daniil Arinic", "https://videos.com/video", true, 60);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();
            */

            /*
            Dog dog = new Dog("Sif", 15);

            Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
            dog.MakeSound();
            dog.Play();
            dog.Eat();

            */

            /*
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenToRadio();

            TV myTV = new TV(true, "Samsung");
            myTV.SwitchOff();
            myTV.WatchTV();
            */
        }
    }
}