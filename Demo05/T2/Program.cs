using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge fridge = new Fridge();
            MicroPizza pitsa = new MicroPizza { Name = "Atria", Condition = "Bad" };

            fridge.AddPitsa(pitsa);
            fridge.AddPitsa(pitsa);
            fridge.AddPitsa(pitsa);
            fridge.AddPitsa(pitsa);

            Console.WriteLine(fridge.ToString());

        }
    }
}
