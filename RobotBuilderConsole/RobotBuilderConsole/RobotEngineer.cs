using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilderConsole
{
    public class RobotEngineer
    {
        private RobotBuilder robotBuilder;

        //OldRobotBuilder specification is sent to the engineer
        public RobotEngineer(RobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        //Return the robot made from the OldRobotBuilder spec
        public Robot getRobot()
        {
            return this.robotBuilder.getRobot();
        }

        //Excecute the methods specific to the RobotBuilder
        //that implements RobotBuilder (OldRobotBuilder)

        public void makeRobot()
        {
            this.robotBuilder.buildRobotHead();
            this.robotBuilder.buildRobotTorso();
            this.robotBuilder.buildRobotArms();
            this.robotBuilder.buildRobotLegs();
        }
    }
}
