using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Tiger : Animal
    {
        public Tiger(string Name)
        {
            type = "Тигр";
            name = Name;
        }
        public override void Voice()
        {
            Console.WriteLine("R-r-r-r-r-r-r");
        }
    }
}
