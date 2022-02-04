using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class CNewReleaseFilm:CFilm
    {
        public CNewReleaseFilm(string title) : base(FilmType.NewRelease,title, 2)
        {

            filmBonusPoint = 2;
        }

        public override int GetBonusPointDay()
        {
            return 25;
        }

        public override int GetRentDays()
        {
            return 0;
        }
        public override decimal CalculateRentalPrice( int days) 
        {

            return CPrice.PREMIUM_PRICE * days;
        }
    }
}
