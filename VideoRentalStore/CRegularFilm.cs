using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class CRegularFilm:CFilm
    {
        //public CRegularFilm()
        //{ 
        //    FilmType
        //}
        public CRegularFilm(string title) : base(FilmType.RegularFilm, title, 1)
        { 
         }
        public override int GetRentDays()
        {
            return 3;
        }
        public override decimal CalculateRentalPrice( int days)
        {
            decimal dPrice = CPrice.BASIC_PRICE;
            if (days > GetRentDays())
                dPrice += CPrice.BASIC_PRICE * days- GetRentDays();

            return dPrice;
        }
    }
}
