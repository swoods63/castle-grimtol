using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleGrimtol.Game
{
  public class Game : IGame
  {
    Room IGame.CurrentRoom { get; set; }
    Player IGame.CurrentPlayer { get; set; }

    void IGame.Reset()
    {

    }

    void IGame.Setup()
    {

    }

    void IGame.UseItem(string itemName)
    {

    }
  }
}


//  public class Game : IGame
//     {
//         public Room CurrentRoom {get; set;}
//         public Player CurrentPlayer{get; set;}
//         public void Setup()
//         {

//         }
//         public void Reset()
//         {

//         }
//         public void UseItem(string itemName)
//         {

//         }
        

//     }
// }