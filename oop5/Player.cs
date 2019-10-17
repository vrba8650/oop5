using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    class Player
    {
        //3 players on each team
        //location of the player

        public Player(Location location)
        {
            this.PlayerPosition = location;
        }

        public Location PlayerPosition { get; set; }
    }
}
