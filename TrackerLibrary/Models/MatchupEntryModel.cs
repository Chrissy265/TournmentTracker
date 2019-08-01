using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
   public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the socre for this particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Respresents the matchup that this team  cam 
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
