using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    public class CCustomer
    {
        public int FilmBonusPonts { get; set; }
        public string Name { get; set; }
        public CCustomer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return  Name ;
        }
        
    }
}
