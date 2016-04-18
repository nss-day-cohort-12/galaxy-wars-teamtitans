using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
    interface IReligious
    {
        // begin encrypt bonus
        void beginEncryptBonus();

        // end encrypt bonus
        void endEncryptBonus();

        // faith bonus
        Population FaithBonus(Population population);
    }
}
