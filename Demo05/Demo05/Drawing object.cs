using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    abstract class Drawing_object
    {
        public string Name { get; set; }
        public abstract void Draw();
    }
}
