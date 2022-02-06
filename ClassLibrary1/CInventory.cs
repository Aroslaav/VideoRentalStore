using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static VideoRentalStore.CFilm;
using System.ComponentModel;

namespace VideoRentalStore
{
    /// <summary>
    ///     Inventory class
    /// </summary>
    public class CInventory
    {
        /// <summary>Contains a list of <see cref="CFilm"/> "/>">.</summary>
        BindingList<CFilm> Films = new BindingList<CFilm>();
        private BindingList<CFilm> currentDataset = new BindingList<CFilm>();

        /// <summary>
		/// Gets filtered films.  
		/// </summary>
		/// <example>For example:
		/// <code>
        /// inventory.ListAllFilm();
		/// object DataSource = inventory.CurrentDataset;
		/// </code>
		/// results in <c>DataSource</c>'s having the value all films.
		/// </example>
		/// <value>Filtered films.</value>
        public BindingList<CFilm> CurrentDataset { get { return currentDataset; }  }

        /// <summary>
        /// This method changing the type of a film.  
        /// </summary>
        /// <param><c>film</c> current film.
        /// </param>
        /// <param><c>type</c> new type of film.
        /// </param>
        /// <example>For example:
        /// <code>
        /// CFilm film = new CNewReleaseFilm();
        /// FilmType type = FilmType.OldFilm;
        /// CApp.GetApp.inventory.ChangeTypeOfFilm(film, type);
        /// </code>
        /// results in <c>film</c>'s having the class COldFilm.
        /// </example>
        /// <returns>The film with changed type</returns>
        public CFilm ChangeTypeOfFilm(CFilm film, FilmType type)
        {
            int indexInList = currentDataset.IndexOf(film);
            //CFilm newFilm;//new CRegularFilm(txtName.Text);
            switch (type)
            {
                case FilmType.NewRelease:
                    film = new CNewReleaseFilm(film);//newFilm;//CFilm.Convert<CNewReleaseFilm>(newFilm);  
                    break;
                case FilmType.OldFilm:
                    film = new COldFilm(film);//(COldFilm)newFilm; 
                    break;
                case FilmType.RegularFilm:
                    film = new CRegularFilm(film);//(CRegularFilm)newFilm; 
                    break;
            }

            if (indexInList >= 0)
                currentDataset[indexInList] = film;

            return film;
        }


        /// <summary>
        /// This method add the film to list of films.  
        /// </summary>
        /// <param><c>film</c> instance of film.
        /// </param>
        public void AddFilm(CFilm film)
        {
            Films.Add(film);
            if (!currentDataset.Contains(film))
                currentDataset.Add(film);
        }

        /// <summary>
        /// This method remove the film from list of films.  
        /// </summary>
        /// <param><c>film</c> instance of film.
        /// </param>
        public void RemoveFilm(CFilm film)
        {
            Films.Remove(film);
            if (currentDataset.Contains(film))
                currentDataset.Remove(film);
        }

        /// <summary>
        /// This method list all films.  
        /// </summary>
        public void ListAllFilm()
        {
            currentDataset = new BindingList<CFilm>(Films.ToList<CFilm>());
            //return Films;
        }

        /// <summary>
        /// This method list all films in store (e.g. not rented at the moment) .
        /// </summary>
        public void ListAllFilmInStore()
        {
            currentDataset = ListAllFilmInStoreBL();
            //return (List < CFilm > )Films.Where(f => f.Available ).ToList<CFilm>();
        }

        /// <summary>
        /// This method list all films in store (e.g. not rented at the moment).
        /// </summary>
        /// <returns>List all films in store</returns>
        public BindingList<CFilm> ListAllFilmInStoreBL()
        {
            return new BindingList<CFilm>(Films.Where(f => f.Available).ToList<CFilm>());
        }

    }
}
