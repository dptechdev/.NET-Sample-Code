using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person person = new Person { FirstName = "Jesse", LastName = "Liberty" };
    }

    
}
