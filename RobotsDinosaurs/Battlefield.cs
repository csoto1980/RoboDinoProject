using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Battlefield //game class
    {
        // Member Variables (has a)
        Fleet fleet;
        Herd herd;

        // Constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }

        // Member Methods
     
        //Random selection of which Dino & Robo start battle
        private int RandomBattleSelection()
        {
            //Pick random Robot
            
            //pick random Dino
        }

        //DinoAttackRobo
        public void DinoAttackRobo(int dinoAttackPower, int roboAttackPower)
        {
            //Robo will lose health (depending on Dino's attack power)

        }
        public void RoboAttackDino()
        {

            // Decrease Dino health (by Robo's attack power)

        }
        public void RunGame()
        {

        }
        //RoundOfBattle | random picked winner
        //public int RoundOfBattle(int min, int max)
        //{
        //    Random BattlePoints = new Random();
        //    return BattlePoints.Next(min, max);
        //}

        //Random winner
        //Display Game Winner

        //if Fleet 

        //Determine how dino wins

        //loop runGame until either Fleet or Herd has a health = 0

        //If Fleet wins
    }
}
