using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int valinta = 0;

            Animal cat = new Animal { Name = "Cat" };
            Animal dog = new Animal { Name = "Dog" };
            Box box = new Box();

            do
            {

               

                Console.WriteLine("What is in the box?");
                Console.WriteLine("1. Add Cat");
                Console.WriteLine("2. Add Dog");
                Console.WriteLine("3. Add Nothing");
                Console.WriteLine("4. Open box");
                Console.WriteLine("5. Run");
                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        {
                            box.AddAnimal(cat);
                            Console.WriteLine("+1 cat");
                            break;
                        }
                    case 2:
                        {
                            box.AddAnimal(dog);
                            Console.WriteLine("+1 dog");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You added nothing");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(box.ToString());
                            break;
                        }
                    case 5:
                        {
                            i = 1;
                            Console.WriteLine("You escaped");
                            break;
                        }
                }
            

            } while (i == 0);
        }
    }
}
