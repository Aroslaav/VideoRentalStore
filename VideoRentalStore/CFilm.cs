using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using static VideoRentalStore.CPrice;

namespace VideoRentalStore
{
	/// <summary>
	/// Type of film 
	/// </summary>
	public enum FilmType 
	{
		/// <summary>
		/// New Release
		/// </summary>
		[Display(Name = "New Release")]
		NewRelease,
		/// <summary>
		/// Regular Film
		/// </summary>
		[Display(Name = "Regular Film")]
		RegularFilm,
		/// <summary>
		/// Old Film
		/// </summary>
		[Display(Name = "Old Film")]
		OldFilm
	}

	/// <summary>
	///     Base Film class
	/// </summary>
	public abstract class CFilm 
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="CFilm"/> class.
        /// </summary>
        public CFilm()
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="CFilm"/>  class.
        /// </summary>
        /// <param><c>film</c> is the film to copy the properties to the current film.
        /// </param>
        public CFilm(CFilm film)
		{
			this.Title = film.Title;
			this.Copies = film.Copies;
		}

        /// <summary>
        /// Gets the Bonus points for a film per rental.
        /// </summary>
        /// <example>For example:
        /// A new release gives 2 points and other films give one point per rental.
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm();
        /// int bonusPoint = film.BonusPoint;
        /// </code>
        /// results in <c>bonusPoint</c>'s having the value 2.
        /// </example>
        /// <value>The Bonus Point.</value>
        public abstract int BonusPoint { get; }

        /// <summary>
        /// Gets the Bonus point for a film per day. User can pay points pays the rental for one day.  
        /// </summary>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm();
        /// int bonusPointPerDay = film.BonusPointPerDay;
        /// </code>
        /// results in <c>BonusPointPerDay</c>'s having the value 25.
        /// </example>
        /// <value>The Bonus point per day.</value>
        public abstract int BonusPointPerDay { get; }

        /// <summary>
        /// Gets the film type display name.  
        /// </summary>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm();
        /// string  name = film.FilmTypeText;
        /// </code>
        /// results in <c>name</c>'s having the value 'New release'.
        /// </example>
        /// <value>The film type name.</value>
        [DisplayName("FilmType")]
		public string FilmTypeText 
		{ 
			get 
			{
                var displayName = this.GetType().GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault() as DisplayNameAttribute;
                string name = this.GetType().Name;
				name = (displayName != null ? displayName.DisplayName : name);
				return name;
			} 
		}
		/// <summary>
		/// Gets the film title.  
		/// </summary>
		/// <example>For example:
		/// <code>
		/// CNewReleaseFilm film = new CNewReleaseFilm(){<see cref="Title"/>="Matrix 11"};
		/// string  name = film.FilmTypeText;
		/// </code>
		/// results in <c>name</c>'s having the value 'New release'.
		/// </example>
		/// <value>The film title.</value>
		public string Title { get; set; }

        /// <summary>
        /// Gets available copies of the film.  
        /// </summary>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm(){<see cref="Copies"/>=2};
        /// int  copies = film.Copies;
        /// </code>
        /// results in <c>copies</c>'s having the value 2.
        /// </example>
        /// <value>The film available copies.</value>
        public int Copies { get; set; }

        /// <summary>
        /// Gets availability of the film at the moment.  
        /// </summary>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm(){<see cref="Copies"/>=2};
        /// bool  available = film.Available;
        /// </code>
        /// results in <c>available</c>'s having the value true.
        /// </example>
        /// <value>The film availability at the moment.</value>
        public bool Available
		{
			get { return Copies > 0; }
		}

        /// <summary>
        /// This method gets number of BASIC_PRICE days for a film.  
        /// </summary>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm();
        /// int  basicPriceRentDays = film.GetBasicPriceRentDays();
        /// </code>
        /// results in <c>basicPriceRentDays</c>'s having the value 0.
        /// </example>
        /// <returns>A number of BASIC_PRICE days for a film</returns>
        public abstract int GetBasicPriceRentDays();

        /// <summary>
        /// This method method of calculating rental price for a film.  
        /// </summary>
        /// <param><c>totalDays</c> is total number of rental days.
        /// </param>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm();
        /// int  price = film.CalculateRentalPrice(2);
        /// </code>
        /// results in <c>price</c>'s having the value 8.
        /// </example>
        /// <returns>A rental price for a film</returns>
        public abstract decimal CalculateRentalPrice(int totalDays);

        /// <summary>
        /// This method method of calculating rental extra days price for a film.  
        /// </summary>
        /// <param><c>extraDays</c> is extra rental days.
        /// </param>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm();
        /// int  price = film.CalculateRentalPriceExtraDays(2);
        /// </code>
        /// results in <c>price</c>'s having the value 8.
        /// </example>
        /// <returns>A rental price for a film</returns>
        public abstract decimal CalculateRentalPriceExtraDays(int extraDays);

        /// <summary>
        /// This method of calculating bonus points that user can pay for a film.  
        /// </summary>
        /// <param><c>totalDays</c> is total number of rental days.
        /// </param>
        /// <example>For example:
        /// <code>
        /// CNewReleaseFilm film = new CNewReleaseFilm();
        /// int  points = film.CalculateBonusPoints(2);
        /// </code>
        /// results in <c>points</c>'s having the value 50.
        /// </example>
        /// <returns>A bonus points that user can pay for a film</returns>
        public int CalculateBonusPoints(int totalDays)
		{
			return totalDays * BonusPointPerDay;
		}

        /// <summary>The film description.</summary>
        /// <returns>The film title and type</returns>
        public override string ToString() => string.Format("{0}({1})", Title, FilmTypeText);
    }
}
