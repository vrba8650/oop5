using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5
{
    class Team
    {
        //2 teams 
        public Team(List<Player> teamRoster)
        {
            this.TeamRoster = teamRoster;
        }

        public List<Player> TeamRoster { get; set; }
    }
}
