using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleGrimtol.Game
{
    public interface IItem
    {
        string Name { get; set; }
        string Description { get; set; }
    }
}