using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleGrimtol.Game
{
  public class Player : IPlayer
  {
    int IPlayer.Score { get; set; }
    List<Item> IPlayer.Inventory { get; set; }
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