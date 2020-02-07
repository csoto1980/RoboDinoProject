using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Robot Instantiation
            Robot robot1 = new Robot("Ro-Berto", 10);
            Robot robot2 = new Robot("Ro-Londa", 20);
            Robot robot3 = new Robot("Ro-cker", 30);

            //Dinosaur Instantiation
            Dinosaur dinosaur2 = new Dinosaur("Velociraptor", 10);
            Dinosaur dinosaur3 = new Dinosaur("FlyingDinosaur", 20);
            Dinosaur dinosaur1 = new Dinosaur("T-Rex", 30);

        }
    }
}
