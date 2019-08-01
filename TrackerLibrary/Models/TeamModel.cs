using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
   public  class TeamModel
    {

        /// <summary>
        /// Represents the team's name for the tournment
        /// </summary>
        public string TeamName { get; set; }
        public int Id { get; set; }
        /// <summary>
        /// create a list of personnal that is on a team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>(); 

    }

    

}
