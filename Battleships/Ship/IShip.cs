namespace Battleships.Ship
{
    public interface IShip
    {
        int StartX { get; set; }
        int StartY { get; set; }
        int EndX { get; set; }
        int EndY { get; set; }
        int PartsUp { get; set; }
        bool Sunk { get; set; }
    }
}
