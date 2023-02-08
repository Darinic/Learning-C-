using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    class Car
    {
        // has a relationship with CarIDInfo

        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

       
        
        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the id of {0} and it is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }


        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }
        

        public void ShowDetails()
        {
            Console.WriteLine($"Car color is {Color} and it has {HP} HP");
        }
        
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}
