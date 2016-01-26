using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Box
    {
        public List<Animal> Animal { get; }

        public Box()
        {
            Animal = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animal.Add(animal);
        }

        public override string ToString()
        {
            string sBox = "Box contains:  \n";

            foreach (Animal animal in Animal)
            {
                sBox += animal.ToString() + "\n";
            }
            return sBox;
        }
    }
}
