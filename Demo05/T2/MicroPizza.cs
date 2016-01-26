using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class MicroPizza
    {
        public string Name;
        public string Condition;

        public override string ToString()
        {
            return "Name: " + Name + " condition: " + Condition;
        }
    }
}
