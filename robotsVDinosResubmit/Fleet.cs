using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosResubmit
{
    class Fleet
    {
        List<Robot> robotFleet;

        public Fleet()
        {
            robotFleet = new List<Robot> { new Robot(), new Robot(), new Robot() };
        }
    }
}
