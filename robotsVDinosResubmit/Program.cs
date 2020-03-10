using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Robots v. Dinosaurs!");
            System.Threading.Thread.Sleep(2000);
            Battlefield battlefield = new Battlefield();
            battlefield.Initialize();
            Console.ReadLine();
        }
    }
}
