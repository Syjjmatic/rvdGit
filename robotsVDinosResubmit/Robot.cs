using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Robot
    {
        public string name;
        public int health, powerLevel;
        public Weapon weapon;

        public Robot(int i)
        {
            name = SetName(i);
            health = 100;
            powerLevel = 100;
            weapon = ChooseWeapon();
        }

        public string SetName(int i)
        {
            Console.Clear();
            Console.WriteLine("Set robot " + i + " name: ");
            return Console.ReadLine();
        }

        public Weapon ChooseWeapon()
        {
            while (true)
            {
                Console.WriteLine("\nChoose a weapon:\n" +
                    "[1] Greatsword\n" +
                    "[2] Blaster");
                switch (Console.ReadLine())
                {
                    case "1":
                        return new Greatsword();
                    case "2":
                        return new Blaster();
                    default:
                        Console.WriteLine("Incorrect input. Please choose [1] or [2].");
                        break;
                }
            }
        }

        public void Attack(int health)
        {
            health -= weapon.attackPower;
        }
    }
}
