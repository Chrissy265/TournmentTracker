using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
  public  class PrizeModel
    {
        
        public int Id { get; set; }  //unique identifer for the prize
        /// <summary>
        /// Team placement number of the tournment ex. 1st, 2, 3, and etc
        /// </summary>
        public int  PlaceNumber { get; set; }

        /// <summary>
        /// Team placement name ex First Place, Second Place, Third Place, and etc.
        /// </summary>
        public string  PlaceName { get; set; }

        /// <summary>
        /// Represent the prize dollar amount
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// represents the prize percentage that will be distrubuted to the teams that placed in the tournment
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
       

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;

            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }

    }
 
   /* public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
    {
        PlaceName = placeName;
        int placeNumberValue = 0;
        int.TryParse(placeNumber, out placeNumberValue);
        PlaceNumber = placeNumberValue;
       
        decimal prizeAmountValue = 0;
        decimal.TryParse(prizeAmount, out prizeAmountValue);
        PrizeAmount = prizeAmountValue;

        double prizePercentageValue = 0;
        double.TryParse(prizePercentage, out prizePercentageValue);
        prizePercentage = prizePercentageValue; 

    }*/
}





