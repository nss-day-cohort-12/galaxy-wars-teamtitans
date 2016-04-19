using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    class Saiyan : Species, ISpaceFaring
    {
        public Saiyan()
        {
            this.intelligence += 6;
            this.strength += 4;
            this.charisma += 2;
            this.health += 5;
            this.stealth += 1;
            this.rage += 7;
            this.luck += 1;
            this.communication += 6;
      this.speciesType = "saiyan";
        }

        public void beginsupersaiyanbonus()
        {
            this.attackBonusActive = true;
            this.rage += 1;
            this.stealth += 1;
            this.communication -= 1;
        }

        public void endsupersaiyanbonus()
        {
            this.attackBonusActive = false;
            this.rage -= 1;
            this.stealth -= 1;
            this.communication += 1;
        }

        public Population Resurrectionbonus(Population galaxyPopulation)
        {
            galaxyPopulation.saiyanPopulation += 5000;
            return galaxyPopulation;
        }
    }
}

