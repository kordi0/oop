using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo
{
    class Zoo
    {
        public string type { get; set; }
        public string name { get; set; }
        public Zoo(string Name)
        {
            type = "Detsky";
            name = Name;
        }

        public void Open()
        {
            var Animals = new List<IAnimal>();
            Animals.Add(new Tiger("Зефирка"));
            Animals.Add(new Parrot("Ствол"));
            Animals.Add(new Duck("Хинкаль"));
            Animals.Add(new Elephant("Алексей"));
            Animals.Add(new Chimp("Василиса"));
            Animals.Add(new Duck("Хинкаль 2"));

            Console.WriteLine("Добро пожаловать в наш Зоопарк \n \n ******** \n");

            foreach (var zver in Animals)
            {
                Employee.WorkWithAnimal(zver);
            }
            Console.ReadLine();
        }
    }
}
