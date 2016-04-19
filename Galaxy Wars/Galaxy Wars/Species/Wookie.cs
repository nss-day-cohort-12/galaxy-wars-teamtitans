using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
  class Wookie : Species, IWarrior
  {
    public Wookie()
    {
      this.intelligence += 4;
      this.strength += 6;
      this.charisma += 3;
      this.health += 3;
      this.stealth += 3;
      this.rage += 4;
      this.luck += 5;
      this.communication += 4;
      this.speciesType = "warfare";
      this.speciesName = "Wookies";
    }

    public void beginBerserkerBonus()
    {
      if (this.attackBonusActive == false)
      {
        this.attackBonusActive = true;
        this.rage += 1;
        this.stealth += 1;
      }
    }

    public void endBerserkerBonus()
    {
      if (this.attackBonusActive == true)
      {
        this.attackBonusActive = false;
        this.rage -= 1;
        this.stealth -= 1;
      }
    }

    public Population TacticalBonus(Population galaxyPopulation)
    {
      galaxyPopulation.saiyanPopulation -= 10000;
      galaxyPopulation.ewokPopulation -= 10000;
      galaxyPopulation.wookiePopulation += 2500;
      return galaxyPopulation;
    }
  }
}