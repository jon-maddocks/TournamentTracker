using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntriesModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {            
            //Load text file.
            //Convert the text to List<PrizeModel>.
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max ID.
            int currentID = 1;
            if(prizes.Count > 0)
            {
                currentID = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;
          
            //Add the new record with the new ID(max + 1).
            prizes.Add(model);

            //Convert the prizes to list<string>
            //Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentID = 1;
            if (people.Count > 0)
            {
                currentID = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        // TODO - Refactor to match void methods
        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            int currentID = 1;
            if (teams.Count > 0)
            {
                currentID = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;
            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);
            return model;
        }

        public List<TeamModel> GetTeam_All()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels(TeamFile, PeopleFile, PrizesFile);

            int currentID = 1;
            if (tournaments.Count > 0)
            {
                currentID = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentID;
            model.SaveRoundsToFile(MatchupFile, MatchupEntryFile);

            tournaments.Add(model);
            tournaments.SaveToTournamentFile(TournamentFile);
        }
    }
}
