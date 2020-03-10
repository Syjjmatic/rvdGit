using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Dinosaur
    {
        string type;
        int health;
        int powerLevel;
        int attackPower;
        public Dinosaur(int i)
        {
            type = SetDinoType(i);
            health = 120;
            powerLevel = 100;
            attackPower = 20;         
        }

        string SetDinoType(int i)
        {
            Console.WriteLine("Set dinosaur" + i + "type:");
            return Console.ReadLine();
        }
    }
}
