using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class DefenseCapsule : BaseShip, IDefenseShip
    {
        public DefenseCapsule()
        {
            this.shipName = "Defense Capsule";
        }
        public Population increasePopulation(Population galaxyPopulation)
        {
            galaxyPopulation.saiyanPopulation += (int)Math.Ceiling(galaxyPopulation.saiyanPopulation * .002);
            return galaxyPopulation;
        }
    }
}
