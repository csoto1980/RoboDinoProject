using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Battlefield
    {
        // Member Variables (has a)
        public Fleet fleet = new Fleet();
        public Herd herd = new Herd();
        public bool robotTurn = false;

        // Constructor | Not needed

        // Member Methods
        public void DinoDown(Dinosaur dino)
        {
            if (dino.health <= 0)
            {
                herd.dinosaurs.Remove(dino);
            }
        }
        public void RoboDown(Robot robo)
        {
            if (robo.health <= 0)
            {
                fleet.robots.Remove(robo);
            }
        }
        public void DinoTurn(Dinosaur dino)
        {
            //attack robot in a list
            // dinoAttack
            //give player the option choice who they want to attack
        }
        public void RoboTurn()
        {

        }
        public void RoboWins()
        {

        }
        public void DinoWins()
        {

        }

        public void RunGame()
        {
         //robotTurn = false;
        // Run Game keep running until one is depleted loopers
        }

    }
}
