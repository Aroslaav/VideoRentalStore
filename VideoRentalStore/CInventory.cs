using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static VideoRentalStore.CFilm;
using System.ComponentModel;

namespace VideoRentalStore
{
    public class CInventory
    {
        List<CFilm> Films = new List<CFilm>();
        private BindingList<CFilm> currentDataset = new BindingList<CFilm>();
        public BindingList<CFilm> CurrentDataset { get { return currentDataset; }  }
        public CInventory() { }
        public void ChangeTypeOfFilm(CFilm film, FilmType type)
        {
            film.setFilmType(type);
        }
        public void AddFilm(CFilm film)
        {
            Films.Add(film);
            if (!currentDataset.Contains(film))
                currentDataset.Add(film);
        }

        public void RemoveFilm(CFilm film)
        {
            Films.Remove(film);
            if (currentDataset.Contains(film))
                currentDataset.Remove(film);
        }

        public void ListAllFilm()
        {
            currentDataset = new BindingList<CFilm>(Films);
            //return Films;
        }

        public void ListAllFilmInStore()
        {
            currentDataset = new BindingList<CFilm>(Films.Where(f => f.Available).ToList<CFilm>());
            //return (List < CFilm > )Films.Where(f => f.Available ).ToList<CFilm>();
        }

    }
}
