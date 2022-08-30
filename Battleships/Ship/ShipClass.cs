namespace Battleships.Ship
{
    public class ShipClass : IShip
    {
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int EndX { get; set; }
        public int EndY { get; set; }
        public int PartsUp { get; set; }
        public bool Sunk { get; set; }
    }
}
