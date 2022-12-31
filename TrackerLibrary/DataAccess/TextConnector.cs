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

        public PrizeModel CreatePrize(PrizeModel model)
        {            
            //Load text file.
            //Convert the text to List<PrizeModel>.
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max ID.
            int currentID = 1;
            if(prizes.Count > 0)
            {
                currentID = prizes.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentID;
          
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
                currentID = people.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentID;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }
    }
}
