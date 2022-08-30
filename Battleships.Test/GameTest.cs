using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships;
using FluentAssertions;
using Xunit;

namespace Battleships.Test
{
    public class GameTest
    {
        [Fact]
        public void TestPlay()
        {
            var ships = new[] { "3:2,3:5" };
            var guesses = new[] { "7:0", "3:3" };
            Game.Play(ships, guesses).Should().Be(0);
        }

        [Fact]
        public void ShouldReturnOne_IfOneShipIsSunked()
        {
            var ships = new[] { "3:2,5:2" };
            var guesses = new[] { "3:2", "4:2", "5:2" };
            Game.Play(ships, guesses).Should().Be(1);
        }
    }
}
