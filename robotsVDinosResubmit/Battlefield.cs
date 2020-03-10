using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Battlefield
    {
        Herd herd;
        Fleet fleet;

        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        public void DisplayDinosaurs()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Dinosaur " + (i + 1) + ": " + herd.dinosaurHerd[i].type + ", " + herd.dinosaurHerd[i].health + " hitpoints");
            }
        }

        public void DisplayRobots()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Robot " + (i + 1) + ": " + fleet.robotFleet[i].name + ", " + fleet.robotFleet[i].health + " hitpoints, " +
                    fleet.robotFleet[i].weapon.type);
            }
        }

        public void FirstAttack()
        {
            int random = RNG.random.Next(2);
            if (random == 1)
            {
                Console.WriteLine("Robots strike first!");
            }
            else
            {
                Console.WriteLine("Dinosaurs strike first!");
            }

        }

        public void Initialize()
        {
            Console.Clear();
            DisplayDinosaurs();
            Console.WriteLine();
            DisplayRobots();
            Console.WriteLine();
            FirstAttack();

        }
    }
}
