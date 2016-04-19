using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
  public class Ewok : Species, IReligious
  {
    public Ewok()
    {
      this.intelligence += 3;
      this.strength += 2;
      this.charisma += 6;
      this.health += 1;
      this.stealth += 8;
      this.rage += 2;
      this.luck += 7;
      this.communication += 3;
      this.speciesType = "religion";
      this.speciesName = "Ewoks";
    }

    public void beginEncryptBonus()
    {
      this.attackBonusActive = true;
      this.communication += 5;
    }

    public void endEncryptBonus()
    {
      this.attackBonusActive = false;
      this.communication -= 5;
    }

    public Population FaithBonus(Population galaxyPopulation)
    {
      galaxyPopulation.ewokPopulation += (int)(galaxyPopulation.saiyanPopulation * 0.01);
      galaxyPopulation.saiyanPopulation -= (int)(galaxyPopulation.saiyanPopulation * 0.01);
      galaxyPopulation.ewokPopulation += (int)(galaxyPopulation.wookiePopulation * 0.01);
      galaxyPopulation.wookiePopulation -= (int)(galaxyPopulation.wookiePopulation * 0.01);
      return galaxyPopulation;
    }

  }
}
