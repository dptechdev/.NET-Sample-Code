using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    
      {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            //Fill the List<int> by using the Add method
            foreach (int num in new int[12] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })
            {
                numbers.Add(num);
            }

            //Insert an element in the penultimate position in the list, and move the last item 
            //up -- The first paramater is the position; the second parameter is the value being inserted

            numbers.Insert(numbers.Count - 1, 99);

            //Remove first element whose value is 7 (the 4th element, index 3)
            numbers.Remove(7);

            //Remove the element that's now the 7th element, index 6 (10)
            numbers.RemoveAt(6);

            //Iterate remaining 11 elements using a for statement
            Console.WriteLine("Iterating using a for statement:");
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i]; //Note the use of Array syntax
                Console.WriteLine(number);
            }

             
            


        }
    }
}
