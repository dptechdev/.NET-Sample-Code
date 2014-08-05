using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPattern
{
    public class EnemyShipFactory
    {
        //This could be used as a static method if we are willing
        //to give up subclassing it

        public EnemyShip makeEnemyShip(string newShipType)
        {
            EnemyShip newShip = null;
            if (newShipType.Equals("U"))
            {
                return new ufoenemyship();
            }
            else
            {
                if (newShipType.Equals("B"))
                {
                    return new BigUFOEnemyShip();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
