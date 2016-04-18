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
      // Arrange
      Wookie wookieArmy = new Wookie();

      //Act

      //Assert
      Assert.IsInstanceOfType(wookieArmy, typeof(Wookie));
    }

    [TestMethod]
    public void TestWookieTacticalAffectsPopulation()
    {
      //Arrage
      Population galaxyPopulation = new Population();
      int ewoks = galaxyPopulation.ewokPopulation;
      Wookie wookieArmy = new Wookie();

      // Act
      galaxyPopulation = wookieArmy.TacticalBonus(galaxyPopulation);

      // Assert
      Assert.AreEqual(galaxyPopulation.ewokPopulation, (ewoks - 10000) );
      Assert.AreEqual(galaxyPopulation.saiyanPopulation, (1000000 - 10000));
      Assert.AreEqual(galaxyPopulation.wookiePopulation, (1000000 + 2500));
    }

    [TestMethod]
    public void TestWookieBerserkAffectsWookie()
    {
      Wookie wookieArmy = new Wookie();

      wookieArmy.beginBerserkerBonus();

      Assert.AreEqual(wookieArmy.rage, 5);
      Assert.IsTrue(wookieArmy.attackBonusActive);

      // test that it can only be applied x1
      wookieArmy.beginBerserkerBonus();

      Assert.AreEqual(wookieArmy.rage, 5);
      Assert.IsTrue(wookieArmy.attackBonusActive);
    }
  }
}
