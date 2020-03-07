using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Robot
    {
        // Member Variables (has a)
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon; 
        
        // Constructor
        public Robot() //need to add Weapon in constructor
        {
            name = RobotName();
            RobotWeapon();
            health = 100;
            powerLevel = 100;
        }

        // Member Methods
        public string RobotName()
        {
            Console.WriteLine("Robot name?");
            return Console.ReadLine();
        }
        public void RobotWeapon()
        {
            weapon = new Weapon("Sword", 10);
        }
        public void AttackDino(Dinosaur dino)
        {
            // Robo attacks dino
            dino.health -= weapon.attackPower;
        }
    }
}
