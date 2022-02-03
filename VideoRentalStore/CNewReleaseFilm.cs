using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class CNewReleaseFilm:CFilm
    {
        public CNewReleaseFilm(string title) : base(FilmType.NewRelease,title, 2)
        { }
         
    }
}
