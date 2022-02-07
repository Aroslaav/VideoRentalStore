using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VideoRentalStore
{
    [DisplayName("Regular")]
    public class CRegularFilm:CFilm
    {
        public CRegularFilm() { }

        public CRegularFilm(CFilm film) : base(film)
        {
        }
        #region Overridables
        public override int BonusPoint { get { return 1; } }
        public override int GetBasicPriceRentDays()
        {
            return 3;
        }
        public override int BonusPointPerDay { get { return 25; } }

        public override decimal CalculateRentalPrice( int days)
        {
            decimal dPrice = CPrice.BASIC_PRICE;
            if (days > GetBasicPriceRentDays())
                dPrice += CPrice.BASIC_PRICE * days - GetBasicPriceRentDays();

            return dPrice;
        }

        public override decimal CalculateRentalPriceExtraDays( int extraDays)
        {
            return (CPrice.PREMIUM_PRICE * extraDays);
        }
        #endregion
    }
}
