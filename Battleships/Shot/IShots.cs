using Battleships.Ship;
using System.Collections.Generic;

namespace Battleships.Shot
{
    public interface IShots
    {
        List<IShot> AllShots { get; set; }

        void ShootAllShots(IShip[,] playGround);
    }
}