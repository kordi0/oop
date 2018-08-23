using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Elephant : Animal
    {
        public Elephant(string Name)
        {
            type = "Слон";
            name = Name;
        }
        public override void Voice()
        {
            Console.WriteLine("Я слон");
        }
    }
}
