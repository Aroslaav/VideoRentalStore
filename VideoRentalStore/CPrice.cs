using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VideoRentalStore
{
    public class CPrice
    {
		/*
         * •	New releases – Price is PREMIUM_PRICE times number of days rented.
•	Regular films – Price is BASIC_PRICE for the fist 3 days and then BASIC_PRICE times the number of days over 3
•	Old film - Price is BASIC_PRICE for the fist 5 days and then BASIC_PRICE times the number of days over 5

         */
		public const decimal PREMIUM_PRICE = 5;
		public const decimal BASIC_PRICE = 4;
		public enum PriceType
		{
			PREMIUM_PRICE,
			BASIC_PRICE
		}

		//decimal GetPrice(PriceType priceType)

		//{ 
		//}
	}
}
