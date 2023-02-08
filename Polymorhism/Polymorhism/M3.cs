using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorhism
{
    internal class M3:BMW
    {
        public M3(int hp, string color, string model):base(hp,color, model)
        {
        }

        //sealed override void Repair()
        /*
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}
