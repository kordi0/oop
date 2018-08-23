using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Duck : Animal
    {
        public Duck(string Name)
        {
            type = "Утка";
            name = Name;
        }
        public override void Voice()
        {
            Console.WriteLine("Кря-кря");
        }
    }
}
