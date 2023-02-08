using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    class BMW:Car
    {
        public string Model { get; set; }

        private string brand = "BMW";

        public BMW(int hp, string color, string model):base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine($"Car brand is {brand},the color is {Color}, model is {Model} and it has {HP} HP");
        }

        public sealed override void Repair()
        {
            Console.WriteLine($"The {brand} model {Model} was repaired!");
        }



    }
}
