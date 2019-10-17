using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    class Program
    {
        static void Main(string[] args)
        {
            Location reff = new Location(0, 0);
            Location ball = new Location(1,1);

            List<Player> roster1 = new List<Player>();
            roster1.Add(new Player(new Location(-3,3)));
            roster1.Add(new Player(new Location(2, -3)));
            roster1.Add(new Player(new Location(4, 3)));

            List<Player> roster2 = new List<Player>();
            roster2.Add(new Player(new Location(0, 3)));
            roster2.Add(new Player(new Location(1, 3)));
            roster2.Add(new Player(new Location(-4,2)));

            Team team1 = new Team(roster1);
            Team team2 = new Team(roster2);

            Game game = new Game(team1, team2, reff, ball);

        }
    }
}
