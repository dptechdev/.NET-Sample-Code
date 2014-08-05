using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testbind1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person Derek = new Person {FirstName = "Derek", LastName = "Pauley" };
      
    }
}
