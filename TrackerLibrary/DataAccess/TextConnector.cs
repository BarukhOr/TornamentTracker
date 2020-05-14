using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePrize for text files
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // TODO: Load the text file
            // TODO: Convert the text to List<PrizeModel>
            // TODO: Find the highest/biggest ID
            // TODO: Create a new record with a new id where the id is +1 of the highest id found within the list of loaded prizes
            // TODO: Convert the prizes to list<String>
            // Save the list<string> to the text file
            throw new NotImplementedException();
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            return null;
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
        }
    }
}
