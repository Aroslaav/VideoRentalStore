using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalStore
{
    class CApp
    {
        static protected CApp _instance = null;
        public static CApp GetApp
        {
            get
            {
                if (_instance == null)
                    _instance = new CApp();
                return _instance;
            }
        }
    }
}
