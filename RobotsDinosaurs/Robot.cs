using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Robot
    {
        // Member Variables
        string name;
        int health;
        int powerLevel;
        int attackPower;
        Weapon shotGun;
        Weapon grenade;
        Weapon machineGun;
        Weapon missile;
        
        // Constructor
        public Robot(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
            health = 100;
            powerLevel = 100;
        }

        // Member Methods
        
        //AttackDinosaur()

        //ChangeInPowerLeve()

        //ChangeWeapon()

        //ChangeInHealth()

        //ChangeINPowerLevel()




    }
}
