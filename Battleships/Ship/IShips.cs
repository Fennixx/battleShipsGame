using System.Collections.Generic;

namespace Battleships.Ship
{
    public interface IShips
    {
        List<IShip> AllShips { get; set; }
        int SunkedShips { get; set; }
        int CountSunkedShips(List<IShip> allShips);
    }
}