using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    class COrder
    {
        CCustomer customer { get; set; }
        CFilm film { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int PlanningRentDays { get; set; }
        decimal Price { get; set; }
        int FilmBonusPonts {
            get {

                return  film.getFilmBonusPonts((EndDate - StartDate).Days);
            }  
        }

        void StrartRent(bool UseBonusPonts,int RentDays)
        {
            StartDate = DateTime.Now;
            PlanningRentDays = RentDays;
            Price= film.CalculateRentalPrice(UseBonusPonts, PlanningRentDays);
        }

        void EndRent(bool UseBonusPonts)
        {
            EndDate = DateTime.Now;
            customer.FilmBonusPonts += FilmBonusPonts;
            int TotalRentDays = (EndDate - StartDate).Days;
            int OverloadedRentDays = TotalRentDays - PlanningRentDays;
            OverloadedRentDays = (OverloadedRentDays > 0 ? OverloadedRentDays: 0);

            Price = film.CalculateRentalPrice(UseBonusPonts, OverloadedRentDays);
        }

        //int calculateBonusPonts()
        //{
        //    int iBonusPoint = 
        //}
    }
}
