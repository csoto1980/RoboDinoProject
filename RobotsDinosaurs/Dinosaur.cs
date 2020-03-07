using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Dinosaur
    {
        // Member Variables
        public string type; 
        public int health;
        public int energy;
        public int attackPower; 

        // Constructor
        public Dinosaur()
        {
            type = ChooseTypeOfDino();
            attackPower = 10;
            health = 100;
            energy = 100;
        }

        // Member Methods
       public string ChooseTypeOfDino()
        {
            Console.WriteLine("Choose Dino:");
            return Console.ReadLine();
        }
        public void AttackRobo(Robot robot) //This passes in a Robot
        {
            //Dino attacks robot
            robot.health -= attackPower;
        }
    }
}
