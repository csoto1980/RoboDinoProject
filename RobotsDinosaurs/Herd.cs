using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    public class Herd
    {
        // Member Variables (Has a) list of robots
        Dinosaur dinosaur1;
        Dinosaur dinosaur2;
        Dinosaur dinosaur3;
        //list of dinosaur
        List<Dinosaur> dinosaurs;
       
        // Constructor
        public Herd()
        {
            dinosaur1 = new Dinosaur("Raptor", 10); //Raptors go in packs
            dinosaur2 = new Dinosaur("Pteradactyl", 20); //Pick up - Fly up - Release 
            dinosaur3 = new Dinosaur("T-Rex", 30); // Attacks by bite
            dinosaurs = new List<Dinosaur>();
        }

        // Member Methods
        
 


    }
}
