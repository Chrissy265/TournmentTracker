using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
   public  class TeamModel
    {

        /// <summary>
        /// create a list of personnal that is on a team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); 

        /// <summary>
        /// Represents the team's name for the tournment
        /// </summary>
        public string TeamName { get; set;  }
    }

    

}
