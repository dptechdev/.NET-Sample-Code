using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPattern
{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            setName("Rocket Enemy Ship");
            setDamage(10.0);
        }
    }
}
