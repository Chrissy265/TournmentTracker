using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class TournamentModel
    {
        /// <summary>
        /// Tournament Name
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Dollar amount of the entry fee for each team.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List the of the teams who entered the tournment
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// List of the prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Will have the list of the matchups by per round in the tournment
        /// </summary>

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>(); 


    

    }
}
