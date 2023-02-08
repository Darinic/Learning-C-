using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    class Audi:Car
    {

        public string Model { get; set; }

        private string Brand = "Audi";

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"Car brand is {Brand},the color is {Color}, model is {Model} and it has {HP} HP");
        }

        public override void Repair()
        {
            Console.WriteLine($"The {Brand} model {Model} was repaired!");
        }
    }
}
