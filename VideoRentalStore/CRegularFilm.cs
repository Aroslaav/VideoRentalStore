using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class CRegularFilm:CFilm
    {
        public CRegularFilm(string title) : base(FilmType.RegularFilm, title, 1)
        { 

        }
    }
}
