using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class MilleniumFalcon : BaseShip, IDefenseShip
    {
        public MilleniumFalcon()
        {
            this.shipName = "Millenium Falcon";
        }
        public Population increasePopulation(Population galaxyPopulation)
        {
            galaxyPopulation.wookiePopulation += (int)Math.Ceiling(galaxyPopulation.wookiePopulation * .001);
            return galaxyPopulation;
        }
    }
}
