using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Herd
    {
        List<Dinosaur> dinosaurHerd;

        public Herd()
        {
            dinosaurHerd = new List<Dinosaur> { new Dinosaur(), new Dinosaur(), new Dinosaur() };
        }
    }
}
