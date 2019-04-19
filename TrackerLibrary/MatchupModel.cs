using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the list of matchups that are entered in the tournment
        /// </summary>
        public List<MatchupEntryModel> Enhtries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents which team is declared winner of the tournment
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Represents the matchup between two teams in  a particular round
        /// </summary>
        public int MatchupRound { get; set; } 

    }
}
