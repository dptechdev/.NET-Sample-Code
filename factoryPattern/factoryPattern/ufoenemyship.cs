using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryPattern
{
    public class ufoenemyship : EnemyShip
    {
        public ufoenemyship()
        {
            setName("UFO Enemy Ship");

            setDamage(20.0);
        }
    }
}
