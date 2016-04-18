using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    interface ISpaceFaring
    {
        //Begin Super Saiyan Bonus
        void beginsupersaiyanbonus();

        //End Super Saiyan Bonus
        void endsupersaiyanbonus();

        //Saiyan Resurrection Bonus
        Population Resurrectionbonus(Population population);
    }
}
