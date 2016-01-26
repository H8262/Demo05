using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vechicle = new Vehicle {Model = "Auto", Name = "Lada" };
            Tyre tyre = new Tyre { Name = "Nokia", Model = "Hakkapeliitta", Size = "Iso" };

            vechicle.AddTyres(tyre);
            vechicle.AddTyres(tyre);
            vechicle.AddTyres(tyre);
            vechicle.AddTyres(tyre);

            Console.WriteLine(vechicle.ToString());
        }
    }
}
