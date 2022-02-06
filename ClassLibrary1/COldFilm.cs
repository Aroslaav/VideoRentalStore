using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VideoRentalStore
{
    /// <summary>
	///     Old Film class
	/// </summary>
    [DisplayName("Old")]
    public class COldFilm:CRegularFilm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="COldFilm"/> class.
        /// </summary>
        public COldFilm() { }

        /// <summary>
		/// Initializes a new instance of the <see cref="COldFilm"/>  class.
		/// </summary>
		/// <param><c>film</c> is the film to copy the properties to the current film.
		/// </param>
        public COldFilm(CFilm film) : base(film)
        {
        }

        #region Overridables
        public override int GetBasicPriceRentDays() => 5;
        #endregion
    }
}
