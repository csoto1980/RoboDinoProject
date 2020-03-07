using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Fleet
    {
        //Member Variables (Has a)
        public List<Robot> robots = new List<Robot>();
        public int numberOfRobos;

        // Constructor | starts out with 3 robots
        public Fleet()
        {
            for (int i = 0; i < numberOfRobos; i++)
            {
                Robot robo = new Robot();
                robots.Add(robo);
            }
        }

        // Member Methods
        public void HowManyRobos()
        {
            Console.WriteLine("How many Robots?");
            numberOfRobos = int.Parse(Console.ReadLine());
        }
    }
}
