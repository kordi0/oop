using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zoo
{
    class Employee
    {
        internal static void WorkWithAnimal(IAnimal zver)
        {
            //throw new NotImplementedException();
            zver.Hello();
            zver.Feed();
            zver.Play();
            zver.Wash();
            zver.Voice();
            Console.WriteLine("\n ******** \n");

            Console.ReadLine();
        }
    }
}
