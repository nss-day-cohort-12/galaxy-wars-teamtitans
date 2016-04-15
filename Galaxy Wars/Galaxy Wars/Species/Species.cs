using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars.Species
{
    public class Species
    {
        public string speciesName { get; set; }
        public string speciesType { get; set; }

        private int _intelligence = 0;
        public int intelligence
        {
            get
            {
                return _intelligence;
            }
            set
            {
                _intelligence = value;
            }
        }

        private int _strength = 0;
        public int strength
        {
            get
            {
                return _strength;
            }
            set
            {
                _strength = value;
            }
        }

        private int _charisma = 0;
        public int charisma
        {
            get
            {
                return _charisma;
            }
            set
            {
                _charisma = value;
            }
        }

        private int _health = 0;
        public int health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        private int _stealth = 0;
        public int stealth
        {
            get
            {
                return _stealth;
            }
            set
            {
                _stealth = value;
            }
        }

        private int _rage = 0;
        public int rage
        {
            get
            {
                return _rage;
            }
            set
            {
                _rage = value;
            }
        }
        private int _luck = 0;
        public int luck
        {
            get
            {
                return _luck;
            }
            set
            {
                _luck = value;
            }
        }

        private int _communication = 0;
        public int communication
        {
            get
            {
                return _communication;
            }
            set
            {
                _communication = value;
            }
        }

    }
}
