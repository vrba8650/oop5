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

        public void PlayerLocations()
        {
            //A list of players + location on the court
            Console.WriteLine("Team 1");
            foreach (Player x in this.Team1.TeamRoster)
            {                
                Console.WriteLine("Player: " + x.PlayerPosition.X + "," + x.PlayerPosition.Y);                
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Team 2");
            foreach (Player y in this.Team2.TeamRoster)
            {               
                Console.WriteLine("Player: " + y.PlayerPosition.X + "," + y.PlayerPosition.Y);
            }
            Console.ReadKey();
        }

        //A list of players distance close to the referee sorted in ascending order
      /*  public double PlayerDistance() 
        {
           Sqrt(X2 - X1)^2 + (Y2 - Y1)^2
        }
    */
        

    }

}

