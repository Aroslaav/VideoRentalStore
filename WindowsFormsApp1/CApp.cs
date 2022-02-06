using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using VideoRentalStore;
using System.Linq;
namespace VideoRentalStoreUI
{
    /// <summary>
    /// Configuration. 
    /// 
    /// <example>
    /// Usage:
    ///		value = CApp.GetApp.PropertyName
    /// </example>
    /// </summary>
    class CApp
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CApp"/> class with filled values(films,customers,orders).
        /// </summary>
        public CApp()
        {
            inventory.AddFilm(new CNewReleaseFilm() { Title = "Matrix 11",Copies = 1 }) ;
            //inventory.AddFilm(new CRegularFilm() { Title = "Spider man ", Copies = 0 });
            //inventory.AddFilm(new CRegularFilm() { Title = "Spider man 2" });
            //inventory.AddFilm(new COldFilm() { Title = "Out of africa" , Copies = 1 });
            customers = new BindingList<CCustomer>() { new CCustomer("James") { BonusPonts=25}, new CCustomer("Robert"), new CCustomer("Mary") };
            orders = new BindingList<COrder>()
            {
                new COrder(customers[0], inventory.ListAllFilmInStoreBL()) { StartDate=DateTime.Now.AddDays(-6),PlanningRentDays=4},
                
            };

        }

        /// <summary>
        /// Instance of the <see cref="CApp"/> class.
        /// </summary>
        static protected CApp _instance = null;

        /// <summary>
        /// Instance of the <see cref="CInventory"/> class .
        /// </summary>
        public CInventory inventory = new CInventory();

        /// <summary>
        /// List of customer orders.
        /// </summary>
        public BindingList<COrder> orders = new BindingList<COrder>();

        /// <summary>
        /// List of customers.
        /// </summary>
        public BindingList<CCustomer> customers = new BindingList<CCustomer>();


        /// <summary>
        /// Accessing a common variables in an application
        /// 
        /// <example>
        /// Usage:
        ///		value = GetApp.Instance.orders
        /// </example>
        /// </summary>
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
