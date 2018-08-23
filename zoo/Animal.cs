using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Animal : IAnimal
    {
        public string type { get; set; }
        public string name { get; set; }

        public void Hello()
        {
            Console.WriteLine($"Привет, я {type} по имени {name}");
        }
        public void Feed()
        {
            Console.WriteLine($"{type} {name} поел");
        }
        public void Play()
        {
            Console.WriteLine($"{type} {name} поигрался");
        }
        public void Wash()
        {
            Console.WriteLine($"{type} {name} помыт");
        }
        public virtual void Voice()
        {
            Console.WriteLine($"гав-гав");
        }
    }    
}
