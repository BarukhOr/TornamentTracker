using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent a prize being offered in this tournament
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int PrizeID { get; set; }
        /// <summary>
        /// The "winning" position to which this prize will be allocated to
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name for this prize
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The amount of money that will be given as the prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the prize pool that will be set aside for this prize
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(String placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            int placeNumberValue = 0;
            decimal placeAmountValue = 0;
            double prizePercentageValue = 0;

            PlaceName = placeName;

            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

            decimal.TryParse(prizeAmount, out placeAmountValue);
            PrizeAmount = placeAmountValue;
        }
    }
}
