using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleGrimtol.Game
{
    public interface IGame
    {
        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

        void Setup();
        void Reset();

        //No need to Pass a room since Items can only be used in the CurrentRoom
        void UseItem(string itemName);

    }
}
