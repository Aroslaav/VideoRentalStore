using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class COldFilm:CRegularFilm
    {
        public COldFilm(string title) : base(title)
        { }

        public override int GetRentDays()
        {
            return 5;
        }
        
    }
}
