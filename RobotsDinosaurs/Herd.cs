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
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();
        public int numberOfDinos;

        // Constructor
        public Herd()
        {
            for (int i = 0; i < numberOfDinos; i++)
            {
                Dinosaur dino = new Dinosaur();
                dinosaurs.Add(dino);
            }
        }
        // Member Methods
        public void HowManyDinos()
        {
            Console.WriteLine("How many dinos?");
            numberOfDinos = int.Parse(Console.ReadLine());
        }
    }
}
