using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy_Wars
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Beginning in the year 3000, the major alien races come together" + System.Environment.NewLine + "whenever the twin suns are aligned to battle to the death.");
      while (true)
      {
        GalaxyWars();
        Console.ReadKey();
      }
    }

    static void GalaxyWars()
    {
      int Year = 3000;
      BattleLogic BattleWorld = new BattleLogic();

      // Randomly select first species to play
      BattleWorld.randomizeFactions();

      // LET THE BATTLE COMMENCE
      bool keepPlaying = true;
      while (keepPlaying)
      {
        BattleWorld.roundRobinRoyale();
        Year++;
        if (
          (BattleWorld.playerOne.isExtinct && BattleWorld.playerTwo.isExtinct) ||
          (BattleWorld.playerTwo.isExtinct && BattleWorld.playerThree.isExtinct) ||
          (BattleWorld.playerThree.isExtinct && BattleWorld.playerOne.isExtinct))
        {
          keepPlaying = false;
        }
      }

      // Check battle state & print (perhaps put in roundRobinRoyale)



      // Check for species extinction and print
      Species winner = new Species();
      if (!BattleWorld.playerOne.isExtinct)
      {
        // Player one wins
        winner = BattleWorld.playerOne;
      }
      else if (!BattleWorld.playerTwo.isExtinct)
      {
        // Player two wins
        winner = BattleWorld.playerTwo;
      }
      else if (!BattleWorld.playerThree.isExtinct)
      {
        // Player three wins
        winner = BattleWorld.playerThree;
      }
      Console.WriteLine(System.Environment.NewLine + "the " + winner.speciesType + "s" + " reign supreme in the year " + Year);
    }
  }
}
