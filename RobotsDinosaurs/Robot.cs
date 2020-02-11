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
        public Weapon weapon; //how to add weapon & it's attack power to robot
        
        // Constructor
        public Robot(string name, Weapon weapon) //need to add Weapon in constructor
        {
            this.name = name;
            this.weapon = weapon;
            health = 100;
            powerLevel = 100;
        }

        // Member Methods

        //AttackDino on a battlefield | loss of health depending on attackPower
        

    }
}
