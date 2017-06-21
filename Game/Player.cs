using System;
using System.Collections.Generic;


namespace CastleGrimtol.Game
{
  public class Player : IPlayer
  {
    public int Score { get; set; }
    public List<Item> Inventory { get; set; }
    public string Character;

    public Player()
    {
      Character = NewCharacter();
      Inventory = new List<Item>();
      Score = 0;
    }

    public string NewCharacter()
    {
      Console.Write("Hey hello! What is your name?");
      string name = Console.ReadLine();
      Console.Write("Hey, " + name + ". You can do this your  the one!");
      Console.Write("If you need help, just type in 'help' or 'h' whenever you need it.");
    }
  }
}



// using System.Collections.Generic;


// namespace CastleGrimtol.Game
// {
//     public class Player : IPlayer
//     {
//         public int Score {get; set;}
//         public List<Item> Inventory {get; set;}
//     }
// }