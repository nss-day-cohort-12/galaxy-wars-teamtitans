using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class SpiritOfEndor : BaseShip, IDefenseShip
    {
        public SpiritOfEndor()
        {
            this.shipName = "The Spirit of Endor";
        }
        public Population increasePopulation(Population galaxyPopulation)
        {
            galaxyPopulation.ewokPopulation += (int)Math.Ceiling(galaxyPopulation.ewokPopulation * .004);
            return galaxyPopulation;
        }
    }
}
