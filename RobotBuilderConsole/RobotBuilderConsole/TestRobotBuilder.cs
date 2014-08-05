using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilderConsole
{
    class TestRobotBuilder
    {
        public static void Main(string[] args)
        {
            //Get a RobotBuilder of type OldRobotBuilder
            RobotBuilder oldStyleRobot = new OldRobotBuilder();

            //Pass the OldRobotBuilder specification to the engineer
            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);

            //Tell the engineer to make the Robot based off of the spec

            Robot firstRobot = robotEngineer.getRobot();

            Console.WriteLine("Robot Built");

            Console.WriteLine("Robot Head Type: " + firstRobot.getRobotHead());
            Console.WriteLine("Robot Torso Type: " + firstRobot.getRobotTorso());
            Console.WriteLine("Robot Arm Type: " + firstRobot.getRobotArms());
            Console.WriteLine("Robot Leg Type: " + firstRobot.getRobotLegs());

        }
    }
}
