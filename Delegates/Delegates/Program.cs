using System.Security.Cryptography.X509Certificates;

namespace Delegates {
    class Program
    {

        public delegate bool FilterDelegate(Person p);
        static void Main(string[] args)
        {

            AudioSystem audioSystem = new AudioSystem();

            RenderingEngine renderingEngine = new RenderingEngine();

            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("The game is running, press any key to end the game");

            Console.ReadKey();

            GameEventManager.TriggerGameOver();

            Console.ReadKey();
            
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);

            DisplayPeople("Adults", people, IsAdult);

            DisplayPeople("Seniors", people, IsSenior);

            Console.ReadKey();
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("---before---");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(Filter);

            Console.WriteLine("---after---");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            DisplayPeople("Adult from age 20-30", people, filter);

            DisplayPeople("All:", people, delegate (Person p)
            {
                return true;
            });

            string searchKeyword = "A";

            DisplayPeople("age >20 with search keyword: " + searchKeyword, people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age >20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            DisplayPeople("exactly 25:", people, p => p.Age == 25);

            Console.ReadKey();
        }

 

        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p) 
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

        static bool Filter(string s)
        {
            //return whether the string s contains the letter 'i'
            //the contaisn method will return a bool which we will return as well
            return s.Contains("i");
        }
    }
}
