using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
  interface IWarrior
  {
    // attack bonus
    Species BerserkerBonus(int battleYear);

    // health bonus
    int TacticalBonus(int battleYear);
  }
}
