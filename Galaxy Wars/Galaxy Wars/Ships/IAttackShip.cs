using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    interface IAttackShip
    {
        Population decreasePopulation(Population galaxyPopulation);
    }
}
