using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPattern
{
    public class EnemyShipTesting
    {
        public static void main(string[] args)
        {
            EnemyShipFactory shipFactory = new EnemyShipFactory();

            //Enemy ship object
            EnemyShip theEnemy = null;

            string userInput = Console.ReadLine();

            Console.WriteLine("What type of ship? (U/ R/ B)");

            if (userInput.Length > 1)
            {
                
            }
        }
    }
}
