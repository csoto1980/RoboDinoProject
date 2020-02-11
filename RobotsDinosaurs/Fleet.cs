using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Fleet //Creating a fleet of Robots
    {
        //Member Variables (Has a)
        Robot robot1;
        Robot robot2;
        Robot robot3;
        //list of robotsl{}
        List<Robot> robots;

        //weapons
        Weapon gun;
        Weapon Granade;
        Weapon Missle;
        //list of weapons
        List<string> weapons = new List<string>();

        // Constructor | starts out with 3 robots
        public Fleet()
        {
            robot1 = new Robot("Trooper1001", new Weapon("Gun", 10));
            robot2 = new Robot("Johnny5", new Weapon("Granade", 20));
            robot3 = new Robot("Terminator", new Weapon("Missile", 30));
            robots = new List<Robot>();
        }

        // Member Methods






    }
}
