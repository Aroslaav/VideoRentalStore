using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VideoRentalStore;

namespace VideoRentalStoreUI
{
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
            cmbCustomer.DataSource =CApp.GetApp.customers;

            foreach (var film in CApp.GetApp.inventory.ListAllFilmInStoreBL())
                cblFilms.Items.Add(film);
           
        }

        void CreateOrder()
        {
            BindingList<CFilm> films = new BindingList<CFilm>();
            foreach (var item in cblFilms.CheckedItems)
                films.Add((CFilm)item);
            COrder order = new COrder((CCustomer)cmbCustomer.SelectedItem, films);
            string message = order.StartRent( (int)nudRentDays.Value);
            MessageBox.Show(message);
            CApp.GetApp.orders.Add(order);
            cmbCustomer.DataSource = CApp.GetApp.customers;
        }


    private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CreateOrder();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
