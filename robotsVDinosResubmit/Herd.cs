﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Herd
    {
        public List<Dinosaur> dinosaurHerd;

        public Herd()
        {
            dinosaurHerd = new List<Dinosaur> { new Dinosaur(1), new Dinosaur(2), new Dinosaur(3) };
        }
    }
}
