using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleGrimtol.Game
{
  public class Room : IRoom
  {
    string IRoom.Name { get; set; }
    string IRoom.Description { get; set; }
    List<Item> IRoom.Items { get; set; }

    void IRoom.UseItem(Item item)
    {
     
    }
  }
}