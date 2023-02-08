using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Box
    {
        private int length;
        private int height;
        //private int width;
        private int volume;

        //short approach (property)
        public int Width { get; set; }

        /*public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
        */

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        public Box(int length, int height, int width)
        {
                this.length = length;
                this.height = height;
                Width = width;
        }
        
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length cannot be negative or 0");
            }
            this.length = length;
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(value < 0)
                {
                    this.height = -value;
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * Width;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {length} and height is {height} and width is {Width} and volume is {volume = length * height * Width}");
        }
    }
}
