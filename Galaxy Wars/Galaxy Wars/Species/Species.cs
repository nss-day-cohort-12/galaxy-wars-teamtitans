using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
  public class Species
  {
    public string speciesName { get; set; }
    public string speciesType { get; set; }

    public bool attackBonusActive { get; set; }
    public bool healthBonusActive { get; set; }

    public int population { get; set; }
    public bool isExtinct { get; set; }

    public Species()
    {
      this.attackBonusActive = false;
      this.healthBonusActive = false;
      this.population = 1000000;
      this.isExtinct = false;
    }

    public int calculateAttackRating()
    {
      Random randomObject = new Random();
      int attackRating = 0;
      /*
      .Next() is calling from arbitrary ranges and can be adjusted for more/less variance.
      */
      attackRating += this.intelligence * randomObject.Next(5, 25);
      attackRating += this.strength * randomObject.Next(5, 25);
      attackRating += this.stealth * randomObject.Next(5, 25);
      attackRating += this.rage * randomObject.Next(5, 25);
      attackRating += this.luck * randomObject.Next(5, 25);
      attackRating += this.communication * randomObject.Next(5, 25);
      return attackRating;
    }

    public int calculateDefenseRating()
    {
      Random randomObject = new Random();
      int defenseRating = 0;
      /*
      .Next() is calling from arbitrary ranges and can be adjusted for more/less variance.
      */
      defenseRating += this.intelligence * randomObject.Next(5, 25);
      defenseRating += this.charisma * randomObject.Next(5, 25);
      defenseRating += this.health * randomObject.Next(5, 25);
      defenseRating += this.stealth * randomObject.Next(5, 25);
      defenseRating += this.luck * randomObject.Next(5, 25);
      defenseRating += this.communication * randomObject.Next(5, 25);
      return defenseRating;
    }

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
