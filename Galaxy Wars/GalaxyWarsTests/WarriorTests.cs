using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Galaxy_Wars;

namespace GalaxyWarsTests
{
  [TestClass]
  public class WarriorTests
  {
    [TestMethod]
    public void TestInstantiateWookieArmy()
    {
      Wookie wookieArmy = new Wookie();

      Assert.IsInstanceOfType(wookieArmy, typeof(Wookie));
    }

    [TestMethod]
    public void TestWookieTacticalAffectsPopulation()
    {
      Population galaxyPopulation = new Population();
      Wookie wookieArmy = new Wookie();

      galaxyPopulation = wookieArmy.TacticalBonus(galaxyPopulation);

      Assert.AreEqual(galaxyPopulation.ewokPopulation, (1000000 - 10000));
      Assert.AreEqual(galaxyPopulation.saiyanPopulation, (1000000 - 10000));
      Assert.AreEqual(galaxyPopulation.wookiePopulation, (1000000 + 2500));
    }
  }
}
