using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Furniture
    {
        public string Color { get; set; }

        public string Material { get; set; }

        public Furniture() 
        {
            Color = "White";
            Material = "Wood";
        }
        
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    
    }
}
