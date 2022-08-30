using System.Collections.Generic;

namespace Battleships.Ship
{
    public class Ships : IShips
    {
        public List<IShip> AllShips { get; set; }
        public int SunkedShips { get; set; }

        public Ships(string[] shipCoordinates)
        {
            AllShips = new List<IShip>();
            CreateShips(shipCoordinates);
        }

        private void CreateShips(string[] ships)
        {
            foreach (var sh in ships)
            {
                ValidateShip(sh);

                var shipArray = sh.Split(',');
                var start = shipArray[0].Split(':');
                var end = shipArray[1].Split(':');

                var ship = new ShipClass()
                {
                    StartX = int.Parse(start[0]),
                    StartY = int.Parse(start[1]),
                    EndX = int.Parse(end[0]),
                    EndY = int.Parse(end[1]),
                    PartsUp = 0,
                    Sunk = false
                };
                AllShips.Add(ship);
            }
        }

        public int CountSunkedShips(List<IShip> allShips)
        {
            foreach (var ship in allShips)
            {
                if (ship.Sunk) SunkedShips++;
            }

            return SunkedShips;
        }

        private static void ValidateShip(string sh)
        {
            //var inputValidationRegex = @"^[0-9]\d{1}[:]{1}[0-9]\d{1}[,]{1}[0-9]\d{1}[:]{1}[0-9]\d{1}$";
            //if (!Regex.IsMatch(sh, inputValidationRegex)) throw new ArgumentException("Wrong format of ship coordinates.");

            //TODO: check if ship already exist
        }
    }
}
