using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    interface IAnimal
    {
        void Hello();
        void Feed();
        void Play();
        void Wash();
        void Voice();
        string type { get; }
        string name { get; }

    }
}
