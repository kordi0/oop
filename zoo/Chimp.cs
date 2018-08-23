using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Chimp : Animal
    {
        public Chimp(string Name)
        {
            type = "Шимпонзе";
            name = Name;
        }
        public override void Voice()
        {
            Console.WriteLine("у у уа ау");
        }
    }
}
