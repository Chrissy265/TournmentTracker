using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

//Load the text file
//Convert the text to List<PrizeModel>
//Find the max ID
//Add the new record with the new ID (max + 1)
//Convert he prizes to list<string>
//Save the list<string> to the text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TExtConnectorProcessor
    {
        public static string FullFilePath(this string fileName)  //PrizeModel.csv returnt the entire path
        {
            //C:\TournamentTracker\"filename"  **filename after the forward slash***
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}"; //goes to the app settings and grabs the value for filePath 
        }

        public static List<string> LoadFile(this string file) //takes in the full file path
        {
            if (!File.Exists(file))   
            {
                return new List<string>(); 
            }

            return File.ReadAllLines(file).ToList(); 
        }

        public static List<PrizeModel> ConverToPrizeModels(this List<string>lines)
        {
            List<PrizeModel> output = new List<PrizeModel>(); 
            
            foreach (string line in lines)  //loop through every line in the text file
            {
                string[] cols = line.Split(',');    //for each line each entries will be separated by commas. Put it in an array as string columns

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);    //wrong input will crash the system, will handle error handling later on
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);

            }

            return output; 
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines, string peopleFile)
        {
            List<PersonModel> output = new List<PersonModel>(); 

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }

            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            //id,team name, list of ids separated by the pipe

            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.Id =int.Parse (cols[0]);
                t.TeamName = cols[1]; 

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.id == int.Parse(id)).First());
                }
                output.Add(t); 
            }

            return output;  
        }

        public static List<TournamentModel> CovertToTournamentModels(this List<string> lines, string teamFileName, string peopleFileName)
        {
            //id= 0
            //Tournament Name = 1
            //EntryFee = 2
            //EnteredTeams = 3
            //Prizes =4
            //Rounds =5
            //id,TournamentName,EntryFee,(id|id|id - Entered Teams),(id|id|id - Prizes),  (Rounds - id^id^id|id^id^id|id^id^id) (represents each list of matchup models)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);   //Takes in peoople file name. 

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    // t.TeamMembers.Add(people.Where(x => x.id == int.Parse(id)).First());
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First()); 
                }
         

        }
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)  //takes the models and convert to a list of strings then write all the lines to the file
        {
            List<string> lines = new List<string>(); 

            foreach(PrizeModel p in models)
            {
                lines.Add($"{ p.Id}, {p.PlaceNumber},{p.PlaceName}, {p.PrizeAmount}, {p.PrizePercentage}"); 
            }

            File.WriteAllLines(fileName.FullFilePath(), lines); 
        }


        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.id}, {p.FirstName}, {p.LastName}, {p.EmailAddress}, {p.CellphoneNumber}"); 
            }

            File.WriteAllLines(fileName.FullFilePath(), lines); 

        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>(); 

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id}, {t.TeamName}, {ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines); 
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count ==0)  //if there is no people on the list don't go through the rest of the process
            {
                return ""; 


            }

            //2|5  split the entries
            foreach (PersonModel p in people)
            {
                output += $"{p.id}|"; 
            }


            output = output.Substring(0, output.Length - 1);
            return output; 
        }
        
    }
}
