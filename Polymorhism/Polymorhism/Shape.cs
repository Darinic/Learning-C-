using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    abstract class Shape
    {
        public string Name { get; set; }
        
        public virtual void GetInfo()
        {
            Console.WriteLine($"\n this is a {Name}");
        }

        public abstract double Volume();
    }
}
