using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    
        
    class Game
    {
            //combines everything together (location, team/players, referee)
            public Game(Team team1, Team team2, Location referee, Location ball)
            {
                this.Team1 = team1;
                this.Team2 = team2;
                this.Referee = referee;
                this.Ball = ball;
            }

            public Team Team1 { get; set; }
            public Team Team2 { get; set; }
            public Location Referee { get; set; }
            public Location Ball { get; set; }

        public int PlayerLocations()
        {
            //A list of players + location on the court
            foreach (Player x in this.Team1.TeamRoster)
            {

            }
            return;
        }


    }

}

