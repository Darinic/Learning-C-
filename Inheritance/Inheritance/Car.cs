using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Inheritance
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyableNearby;
        public Car(float speed, string color) : base(speed, color)
        {
            DestructionSound = "CarDestructionSound.mp3";
            DestroyableNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} car was destroyed ");
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning car parts");

            foreach (IDestroyable destroyable in DestroyableNearby)
            {
                destroyable.Destroy();
            }
        }
    }
    
}
