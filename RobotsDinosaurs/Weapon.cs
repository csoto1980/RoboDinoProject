using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Weapon
    {
        // Member Variables (Has a)
        string type;   //Gun, Granade, Missile
        int attackPower; // 10, 20, 30

        // Constructor
        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }

        // Member Methods


    }
}
