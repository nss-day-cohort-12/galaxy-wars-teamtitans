using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class FurBucket : BaseShip, IAttackShip
    {
        public FurBucket()
        {
            this.shipName = "Fur Bucket";
        }

        public Population decreasePopulation(Population galaxyPopulation)
        {
            galaxyPopulation.wookiePopulation -= (int)Math.Ceiling(galaxyPopulation.wookiePopulation * .001);
            galaxyPopulation.saiyanPopulation -= (int)Math.Ceiling(galaxyPopulation.saiyanPopulation * .001);
            return galaxyPopulation;
        }
    }
}
