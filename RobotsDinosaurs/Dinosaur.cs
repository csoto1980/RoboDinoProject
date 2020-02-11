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
        string type; //Raptor, Pteradactyl, T-Rex
        int health;
        int energy;
        int attackPower; //attackPower 1-Bite 2-Claw 3-tailwhip

        // Constructor
        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
            health = 100;
            energy = 100;
        }

        // Member Methods
       
        //AttackRobot on a battlefield | Loss of health depending on attackPower




    }
}
