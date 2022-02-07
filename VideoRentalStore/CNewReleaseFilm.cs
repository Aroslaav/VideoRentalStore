using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VideoRentalStore
{
    /// <summary>
    ///     New release Film class
    /// </summary>
    [DisplayName("New release")]
    public class CNewReleaseFilm: CRegularFilm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CNewReleaseFilm"/> class.
        /// </summary>
        public CNewReleaseFilm() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CNewReleaseFilm"/>  class.
        /// </summary>
        /// <param><c>film</c> is the film to copy the properties to the current film.
        /// </param>
        public CNewReleaseFilm(CFilm film) : base(film)
        {
        }

        public override int BonusPoint { get { return 2; } }
        public override int GetBasicPriceRentDays() => 0;
        public override decimal CalculateRentalPrice(int days) => CPrice.PREMIUM_PRICE * days;

        
    }
}
