using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VideoRentalStore
{
    /// <summary>
    ///     Order class
    /// </summary>
    public class COrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="COrder"/>  class.
        /// </summary>
        /// <param><c>customer</c> is the customer.
        /// </param>
        /// /// <param><c>films</c> is the selected films.
        /// </param>
        public COrder(CCustomer customer, BindingList<CFilm> films)
        {
            Customer = customer;
            Films = films;
        }

        /// <value>Property <c>Y</c> represents the Customer.</value>
        public CCustomer Customer { get; set; }

        /// <summary>
		/// Gets and sets selected films.  
		/// </summary>
		/// <example>For example:
		/// <code>
        /// inventory.ListAllFilm();
		/// object DataSource = inventory.CurrentDataset;
		/// </code>
		/// results in <c>DataSource</c>'s having the value all films.
		/// </example>
		/// <value>Selected films.</value>
        BindingList<CFilm> Films { get; set; }

        /// <summary>
        /// Gets and sets the order start date.  
        /// </summary>
        /// <value>The order start date</value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets and sets the order end date.  
        /// </summary>
        /// <value>The order end date</value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets and sets the order planning rent days.  
        /// </summary>
        /// <value>The order planning rent days</value>
        public int PlanningRentDays { get; set; }

        /// <summary>
        /// Gets and sets the order Price.  
        /// </summary>
        /// <value>The order price</value>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets and sets the order extra price.  
        /// </summary>
        /// <value>The order extra price</value>
        public decimal ExtraPrice { get; set; }


        /// <summary>
        /// This method of calculating bonus points that user can get for a films.  
        /// </summary>
        /// <returns>A bonus points that user can get for a films</returns>
        int CalculateBonusPonts()
        {
            int iBonusPonts = 0;
            foreach (var film in Films)
                iBonusPonts += film.BonusPoint;
            return iBonusPonts;
        }

        /// <summary>
        /// This method of start the rent.  
        /// </summary>
        /// <returns>A string representing a bill </returns>
        public string StartRent( int RentDays)
        {
            StringBuilder filmsPrint = new StringBuilder();
            int filmBonusPoint = 0;
            int filmPaidBonusPoint = 0;
            decimal filmRentalPrice = 0;
            string filmPrint = "";
            string extrenalDescription = "";
            
            StartDate = DateTime.Now;
            PlanningRentDays = RentDays;
            Price = 0;

            Customer.BonusPonts += CalculateBonusPonts();

            foreach (var film in Films)
            {
                film.Copies--;
                filmRentalPrice = film.CalculateRentalPrice(PlanningRentDays);

                filmBonusPoint = film.CalculateBonusPoints(PlanningRentDays);
                extrenalDescription = "";
                if (filmBonusPoint <= Customer.BonusPonts)
                {
                    filmPaidBonusPoint = filmBonusPoint;
                    filmRentalPrice = 0;
                    Customer.BonusPonts -= filmBonusPoint;
                    extrenalDescription = string.Format("(Paid with {0} Bonus points)", filmPaidBonusPoint);
                }
                else {
                    extrenalDescription = string.Format("{0} EUR", filmRentalPrice);
                }
                Price += filmRentalPrice;

                filmPrint = string.Format("{0} {1} days {2}", film.ToString(), PlanningRentDays, extrenalDescription);
                filmsPrint.AppendLine(filmPrint);

            }
            filmPrint = string.Format("Total price : {0} EUR", Price);
            filmsPrint.AppendLine(filmPrint);
            if (Customer.BonusPonts > 0)
            {
                filmPrint = string.Format("Remaining Bonus points: {0}", Customer.BonusPonts);
                filmsPrint.AppendLine(filmPrint);
            }
            return filmsPrint.ToString();
        }

        /// <summary>
        /// This method of end the rent.  
        /// </summary>
        /// <returns>A string representing a bill </returns>
        public string EndRent()
        {
            decimal totalPrice = 0;
            StringBuilder filmsPrint = new StringBuilder();
            EndDate = DateTime.Now;
            string filmPrint = "";
            int TotalRentDays = (EndDate - StartDate).Days;
            
            foreach (var film in Films)
            {
                film.Copies++;
                int OverloadedRentDays = TotalRentDays - PlanningRentDays;
                OverloadedRentDays = (OverloadedRentDays > 0 ? OverloadedRentDays : 0);
                if (OverloadedRentDays > 0)
                {
                    ExtraPrice = film.CalculateRentalPriceExtraDays( OverloadedRentDays);
                    totalPrice += ExtraPrice;
                   
                    filmPrint = string.Format("{0} {1} extra days {2} EUR", film.ToString(), OverloadedRentDays, ExtraPrice);
                    filmsPrint.AppendLine(filmPrint);
                }
                
            }

            Price += totalPrice;
            filmPrint = string.Format("Total price : {0} EUR", totalPrice);
            filmsPrint.AppendLine(filmPrint);

            return filmsPrint.ToString();
        }
    }
}
