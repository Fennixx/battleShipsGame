using Battleships.Ship;
using System.Collections.Generic;

namespace Battleships.Shot
{
    public class Shots : IShots
    {
        public List<IShot> AllShots { get; set; }

        public Shots(string[] shots)
        {
            AllShots = new List<IShot>();
            CreateShots(shots);
        }

        private void CreateShots(string[] guesses)
        {
            foreach (var sh in guesses)
            {
                ValidateShot(sh);
                var s = sh.Split(':');
                var shot = new ShotClass() { X = int.Parse(s[0]), Y = int.Parse(s[1]) };
                AllShots.Add(shot);
            }
        }

        public void ShootAllShots(IShip[,] playGround)
        {
            foreach (var shot in AllShots)
            {
                if (playGround[shot.X, shot.Y] != null)
                {
                    if (--playGround[shot.X, shot.Y].PartsUp == 0) playGround[shot.X, shot.Y].Sunk = true;
                }
            }
        }

        private static void ValidateShot(string sh)
        {
            //var inputValidationRegex = @"^[0-9]\d{1}[,]{1}[0-9]\d{1}$";
            //if (!Regex.IsMatch(sh, inputValidationRegex)) throw new ArgumentException("Wrong format of shot coordinates.");

            //TODO: check if shot already exist
        }
    }
}
