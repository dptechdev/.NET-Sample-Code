using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] People = {"Derek", "Libby", "Vicki" };
            //Query syntax:
            var peopleSelect =
                from p in People
                where (p.Length == 5)
                select p;

            foreach (string p in peopleSelect)
            {
                Console.WriteLine("The name is: {0}", p);
            }

           
            //Method syntax:
            IEnumerable<string> peopleSelectt = People.
                Where(p => p.Length == 5).OrderBy(p => p);

            foreach (string p in peopleSelectt)
            {
                Console.WriteLine(p);
            }


        }
    }
}
