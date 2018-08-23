using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Parrot : Animal
    {
        public Parrot(string Name)
        {
            type = "Попугай";
            name = Name;
        }
        public override void Voice()
        {
            Console.WriteLine("чирик-чирик");
        }
    }
}
