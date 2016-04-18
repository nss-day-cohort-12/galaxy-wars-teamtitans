using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
  interface IWarrior
  {
    // begin attack bonus
    void beginBerserkerBonus();

    // end attack bonus
    void endBerserkerBonus();

    // health bonus
    Population TacticalBonus(Population population);
  }
}
