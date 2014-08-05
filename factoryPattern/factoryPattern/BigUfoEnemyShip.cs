using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPattern
{
    public class BigUfoEnemyShip : ufoenemyship
    {
        public BigUfoEnemyShip()
        {
            setName("Big UFO Enemy Ship");
            setDamage(40.0);
        }
    }
}
