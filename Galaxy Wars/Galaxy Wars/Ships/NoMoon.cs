using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class NoMoon : BaseShip, IAttackShip
    {
        public NoMoon()
        {
            this.shipName = "No Moon";
        }

        public Population decreasePopulation(Population galaxyPopulation)
        {
            galaxyPopulation.ewokPopulation -= (int)Math.Ceiling(galaxyPopulation.ewokPopulation * .003);
            galaxyPopulation.saiyanPopulation -= (int)Math.Ceiling(galaxyPopulation.saiyanPopulation * .003);
            return galaxyPopulation;
        }
    }
}
