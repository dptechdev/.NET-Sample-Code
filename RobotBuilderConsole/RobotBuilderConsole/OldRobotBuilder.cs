using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilderConsole
{
    public class OldRobotBuilder : RobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }



        public void buildRobotHead()
        {
            robot.SetRobotHead("Tin Head");
        }

        public void buildRobotTorso()
        {
            robot.SetRobotTorso("Tin Torso");
        }

        public void buildRobotArms()
        {
            robot.SetRobotArms("Blowtorch Arms");
        }

        public void buildRobotLegs()
        {
            robot.SetRobotLegs("Roller skates");
        }

        public Robot getRobot()
        {
            return this.robot;
        }
    }
}
