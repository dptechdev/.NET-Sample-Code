using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        delegate void StringDelegate(string param);
        static void Main(string[] args)
        {
            StringDelegate stDel = HelloWorld;
            StringDelegate stDel1 = GoodByeWorld;
            stDel("Derek");
            stDel1("Derek");
            
            

            
        }

        public static void HelloWorld(string param)
        {
            Console.WriteLine("Hello " + param);
        }
        public static void GoodByeWorld(string param)
        {
            Console.WriteLine("Goodbye " + param);
        }

        

    }
}
