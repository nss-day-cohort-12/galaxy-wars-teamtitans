using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
  class BattleLogic
  {
    // Players
    public Species playerOne { get; set; }
    public Species playerTwo { get; set; }
    public Species playerThree { get; set; }

    // Battle
    public void randomizeFactions()
    {
      List<Species> factions = new List<Species>();
      factions.Add(new Saiyan());
      factions.Add(new Wookie());
      factions.Add(new Ewok());
      Random randomizer = new Random();

      // set random first player
      int index = randomizer.Next(0, factions.Count());
      this.playerOne = factions[index];

      // set different (still random) second player
      index = randomizer.Next(0, factions.Count());
      this.playerTwo = factions[index];
      while (playerTwo == playerOne)
      {
        index = randomizer.Next(0, factions.Count());
        playerTwo = factions[index];
      }

      // set remaining unique third player
      index = randomizer.Next(0, factions.Count());
      this.playerThree = factions[index];
      while (playerThree == playerOne || playerThree == playerTwo)
      {
        index = randomizer.Next(0, factions.Count());
        playerThree = factions[index];
      }
    }

    public int calculateKillCount(int selfAttackRating, int enemyDefenseRating)
    {
      Random randomizer = new Random();
      int netAttackRating;
      if (selfAttackRating > enemyDefenseRating)
      {
        netAttackRating = selfAttackRating - enemyDefenseRating;
      }
      else
      {
        netAttackRating = 0;
      }

      int deathToll = netAttackRating * randomizer.Next(25, 31);
      return deathToll;
    }

    public void roundRobinRoyale()
    {
      int killCount = 0;
      // Player 1 attacks Player 2
      if (playerTwo.population > 0)
      {
        killCount = calculateKillCount(
          playerOne.calculateAttackRating(),
          playerTwo.calculateDefenseRating()
          );
      }
      else
      {
        playerTwo.isExtinct = true;
      }

      playerTwo.population -= killCount;

      // Player 1 attacks Player 3
      if (playerThree.population > 0)
      {
        playerThree.population -= calculateKillCount(
          playerOne.calculateAttackRating(),
          playerThree.calculateDefenseRating()
          );
      }
      else
      {
        playerThree.isExtinct = true;
      }

      // Player 2 attacks Player 1
      if (playerOne.population > 0)
      {
        playerOne.population -= calculateKillCount(
          playerTwo.calculateAttackRating(),
          playerOne.calculateDefenseRating()
          );
      }
      else
      {
        playerOne.isExtinct = true;
      }

      // Player 2 attacks Player 3
      if (playerThree.population > 0)
      {
        playerThree.population -= calculateKillCount(
          playerTwo.calculateAttackRating(),
          playerThree.calculateDefenseRating()
          );
      }
      else
      {
        playerThree.isExtinct = true;
      }

      // Player 3 attacks Player 1
      if (playerOne.population > 0)
      {
        playerOne.population -= calculateKillCount(
          playerThree.calculateAttackRating(),
          playerOne.calculateDefenseRating()
          );
      }
      else
      {
        playerOne.isExtinct = true;
      }

      // Player 3 attacks Player 2
      if (playerTwo.population > 0)
      {
        playerOne.population -= calculateKillCount(
          playerThree.calculateAttackRating(),
          playerTwo.calculateDefenseRating()
          );
      }
      else
      {
        playerTwo.isExtinct = true;
      }
    }

    public void weightedBattle(bool isBackwardsCycle)
    {
      int killCount = 0;
      if (playerOne.speciesType == "religion" && playerTwo.speciesType == "science" && isBackwardsCycle)
      {
        int extraKills = (killCount / 100) * 2;
        killCount += extraKills;
        playerOne.population -= killCount;
      }
      else if (playerOne.speciesType == "science" && playerTwo.speciesType == "religion" && !isBackwardsCycle)
      {
        int extraKills = (killCount / 100) * 2;
        killCount += extraKills;
        playerOne.population -= killCount;
      }
      else if (playerOne.speciesType == "warfare" && playerTwo.speciesType == "religion" && isBackwardsCycle)
      {
        int extraKills = (killCount / 100) * 2;
        killCount += extraKills;
        playerTwo.population -= killCount;
      }
      else if (playerOne.speciesType == "religion" && playerTwo.speciesType == "warfare" && !isBackwardsCycle)
      {
        int extraKills = (killCount / 100) * 2;
        killCount += extraKills;
        playerTwo.population -= killCount;
      }
      else if (playerOne.speciesType == "science" && playerTwo.speciesType == "warfare" && isBackwardsCycle)
      {
        int extraKills = (killCount / 100) * 2;
        killCount += extraKills;
      }
      else if (playerOne.speciesType == "warfare" && playerTwo.speciesType == "science" && !isBackwardsCycle)
      {
        int extraKills = (killCount / 100) * 2;
        killCount += extraKills;
      }
    }
  }
}
