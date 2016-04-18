using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class AttackCapsule : BaseShip, IAttackShip
    {
        public AttackCapsule()
        {
            this.shipName = "Attack Capsule";
        }

        public Population decreasePopulation(Population galaxyPopulation)
        {
            galaxyPopulation.wookiePopulation -= (int)Math.Ceiling(galaxyPopulation.wookiePopulation * .002);
            galaxyPopulation.ewokPopulation -= (int)Math.Ceiling(galaxyPopulation.ewokPopulation * .002);
            return galaxyPopulation;
        }
    }
}
