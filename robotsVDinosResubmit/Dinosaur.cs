using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Dinosaur
    {
        public string type;
        public int health, powerLevel, attackPower;

        public Dinosaur(int i)
        {
            type = SetDinoType(i);
            health = 120;
            powerLevel = 100;
            attackPower = 20;         
        }

        string SetDinoType(int i)
        {
            Console.Clear();
            Console.WriteLine("Set dinosaur " + i + " type:");
            return Console.ReadLine();
        }
        
        public void Attack(int health)
        {
            health -= attackPower;
        }
    }
}
