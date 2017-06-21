using System.Collections.Generic;

namespace CastleGrimtol.Game
{
  public class Item : IItem
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public Item (string name, string description)
    {
        name = Name;
        description = Description;
    }
  }
}

