using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represent a prize being offered in this tournament
    /// </summary>
    class PrizeModel
    {
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
    }
}
