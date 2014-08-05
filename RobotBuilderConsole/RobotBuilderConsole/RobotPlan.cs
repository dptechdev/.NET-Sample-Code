using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilderConsole
{
    public interface RobotPlan
    {
         void SetRobotHead(string head);
         void SetRobotTorso(string Torso);
         void SetRobotArms(string Arms);
         void SetRobotLegs(string Legs);
    }
}
