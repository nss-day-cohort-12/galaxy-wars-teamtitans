using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
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

    public Population ReligiousBonus(Population galaxyPopulation)
    {
      galaxyPopulation.ewokPopulation += galaxyPopulation.saiyanPopulation * 0.01;
      galaxyPopulation.saiyanPopulation -= galaxyPopulation.saiyanPopulation * 0.01;
      galaxyPopulation.ewokPopulation += galaxyPopulation.wookiePopulation * 0.01;
      galaxyPopulation.wookiePopulation -= galaxyPopulation.wookiePopulation * 0.01;
      return galaxyPopulation;
    }

  }
}
