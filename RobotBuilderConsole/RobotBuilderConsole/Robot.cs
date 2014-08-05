using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilderConsole
{
    public class Robot : RobotPlan
    {
        private string robotHead;
        private string robotTorso;
        private string robotArms;
        private string robotLegs;

        public void SetRobotHead(string head)
        {
            robotHead = head;
        }

        public string getRobotHead() { return robotHead; }

        public void SetRobotTorso(string torso)
        {
            robotTorso = torso;
        }

        public string getRobotTorso() { return robotTorso; }

        public void SetRobotArms(string arms)
        {
            robotArms = arms;
        }

        public string getRobotArms() { return robotArms; }

        public void SetRobotLegs(string legs)
        {
            robotLegs = legs;
        }

        public string getRobotLegs() { return robotLegs; }
    }
}
