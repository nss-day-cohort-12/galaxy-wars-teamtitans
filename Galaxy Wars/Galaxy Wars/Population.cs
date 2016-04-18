using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
  public class Population
  {
    private int _saiyanPopulation = 1000000;
    public int saiyanPopulation
    {
      get
      {
        return _saiyanPopulation;
      }
      set
      {
        _saiyanPopulation = value;
      }
    }

    private int _wookiePopulation = 1000000;
    public int wookiePopulation
    {
      get
      {
        return _wookiePopulation;
      }
      set
      {
        _wookiePopulation = value;
      }
    }

    private int _ewokPopulation = 1000000;
    public int ewokPopulation
    {
      get
      {
        return _ewokPopulation;
      }
      set
      {
        _ewokPopulation = value;
      }
    }
  }
}
