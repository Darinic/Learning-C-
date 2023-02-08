using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }

        public void ListenToRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the radio");
            }
            else
            {
                Console.WriteLine("The radio is off");
            }
        }
    }
    
}
