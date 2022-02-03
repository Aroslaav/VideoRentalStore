using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class COldFilm:CFilm
    {
        public COldFilm(string title) : base(FilmType.OldFilm, title, 1)
        { }
    }
}
