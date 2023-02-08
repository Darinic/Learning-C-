using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class BoostedDog
    {




        public string Name { get; set; }

        public bool IsNaughtyDog { get; set; }

        public BoostedDog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine("Giving {0} treats to {1}", numberOfTreats, Name);
        }   
    }
    class DogShelter :IEnumerable<BoostedDog>
    {
        public List<BoostedDog> dogs;

        public DogShelter()
        {
            dogs = new List<BoostedDog>()
            {
                new BoostedDog("Casper", false),
                new BoostedDog("Sif", true),
                new BoostedDog("Oreo", false),
                new BoostedDog("Pixel", false),
            };
            
        }

        IEnumerator<BoostedDog> IEnumerable<BoostedDog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
