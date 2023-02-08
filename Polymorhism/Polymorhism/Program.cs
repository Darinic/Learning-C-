using System;
using System.Collections.Generic;
using System.Collections;
using Polymorhism;
using System.IO;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Projects\Assets\input.txt");
            string[] splittedText;
            
            foreach(string line in text)
            {
                if(line.Contains("split"))
                {
                    splittedText = line.Split(" ");

                    using (StreamWriter file = new StreamWriter(@"C:\Projects\Assets\output.txt", true))
                    {
                        file.Write(splittedText[4] + " ");
                    }
                }
            }
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

                Console.ReadKey();
            
            Shape[] shapes =
            {
                new Sphere(4), new Cube(3)
            };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                if (shape is Cube) 
                {
                    Console.WriteLine("This shape is a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine(" {0} has a volume of {1}",cube2.Name, cube2.Volume());
            };


            Console.ReadKey();
            
            List<Car> cars = new List<Car>
            {
                new Audi(200,"blue", "A4"),
                new BMW(250, "red", "M3"),
            };

            foreach (Car car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");

            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Daniil Arinic");
            audiA3.SetCarIDInfo(1235, "Frank Sinatra");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            Car CarB = (Car)bmwM5;

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();

            Console.ReadKey();
        }
    }
}
