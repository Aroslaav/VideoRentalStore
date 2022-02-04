using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class COrder
    {
        public COrder(CCustomer customer, List<CFilm> films)
        {
            Customer = customer;
            Films = films;
        }
        CCustomer Customer { get; set; }
        List<CFilm> Films { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int PlanningRentDays { get; set; }
        decimal Price { get; set; }
        decimal ExtraPrice { get; set; }


        int CalculateBonusPonts()
        {
            int iBonusPonts = 0;
            foreach (var film in Films)
                iBonusPonts += film.getFilmBonusPonts();
            return iBonusPonts;
        }

        string StartRent(bool UseBonusPonts, int RentDays)
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

            Customer.FilmBonusPonts += CalculateBonusPonts();

            foreach (var film in Films)
            {
                filmRentalPrice = film.CalculateRentalPrice(PlanningRentDays);

                filmBonusPoint = film.CalculateBonusPoints(PlanningRentDays);
                extrenalDescription = "";
                if (filmBonusPoint <= Customer.FilmBonusPonts)
                {
                    filmPaidBonusPoint = filmBonusPoint;
                    filmRentalPrice = 0;
                    Customer.FilmBonusPonts -= filmBonusPoint;
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

            return filmsPrint.ToString();
        }

        string EndRent(bool UseBonusPonts)
        {
            StringBuilder filmsPrint = new StringBuilder();
            EndDate = DateTime.Now;
            string filmPrint = "";
            int TotalRentDays = (EndDate - StartDate).Days;
            
            foreach (var film in Films)
            {
                int OverloadedRentDays = TotalRentDays - PlanningRentDays;
                OverloadedRentDays = (OverloadedRentDays > 0 ? OverloadedRentDays : 0);
                if (OverloadedRentDays > 0)
                {
                    Price = film.CalculateRentalPrice(OverloadedRentDays);
                    filmPrint = string.Format("{0} {1} extra days {2} EUR", film.ToString(), PlanningRentDays, Price);
                    filmsPrint.AppendLine(filmPrint);
                }
            }
            return filmsPrint.ToString();
        }

        //int calculateBonusPonts()
        //{
        //    int iBonusPoint = 
        //}
    }
}
