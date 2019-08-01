 using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";

        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels(PeopleFile);

            int currentId = 1; 
            if(people.Count >0)
            {
                currentId = people.OrderByDescending(x => x.id).First().id + 1; 
            }
            model.id = currentId;
            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model; 
        }

        //TODO-Wire up the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)  //each model will have its own text file, each table will have its own text file.
        {
            //Load the text file and convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConverToPrizeModels();

            //Find the max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
               currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;// find the highest id in the list and add one to make the current id for the new record.
            }
                model.Id = currentId;

            //Add the new record with the new ID (max + 1)
            prizes.Add(model);


            //Convert he prizes to list<string>
            //Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);


            return model; 

        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(TeamFile);
            //Find the max ID
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;// find the highest id in the list and add one to make the current id for the new record.
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);
                return model; 

        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath().
                LoadFile().
                CovertToTournamentModels(TeamFile); 
            
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels(PeopleFile); 
        }

        public List<TeamModel> GetTeam_All()
        {
           return  TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(TeamFile); //returns a list of team model 
        }
    }
}
