using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using VideoRentalStore;

namespace VideoRentalStoreUI
{
    
    class CApp
    {

        public CApp()
        {

            inventory.AddFilm(new CNewReleaseFilm("Matrix 11"));
            inventory.AddFilm(new CRegularFilm("Spider man 2"));
            inventory.AddFilm(new CRegularFilm("Spider man 2"));
            inventory.AddFilm(new COldFilm("Out of africa"));
            customers = new BindingList<CCustomer>() { new CCustomer("c1"), new CCustomer("c2"), new CCustomer("c3") };
        }
        public CInventory inventory = new CInventory();
        public BindingList<COrder> orders = new BindingList<COrder>();
        public BindingList<CCustomer> customers = new BindingList<CCustomer>();
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
