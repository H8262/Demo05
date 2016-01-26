using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Fridge
    {
        public List<MicroPizza> Pitsa { get; }
        public Fridge()
            {
            Pitsa = new List<MicroPizza>();
            }
        public void AddPitsa(MicroPizza pitsa)
        {
           Pitsa.Add(pitsa);
        }

        public override string ToString()
        {
            string sFridge = "Fridge contains: ";

            foreach (MicroPizza pitsa in Pitsa)
            {
                sFridge += pitsa.ToString() + "\n";
            }
            return sFridge;
        }
    }
}
