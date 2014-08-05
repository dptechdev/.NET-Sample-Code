using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        

       public void Bark(string name)
        {
            Console.WriteLine("Hello, my name is {0}", name);
        }

    }

    class Program
    {
        //Comment - first C# program --
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Haze";
            myDog.Age = 4;
            myDog.Bark(myDog.Name);
        }
    }
}
