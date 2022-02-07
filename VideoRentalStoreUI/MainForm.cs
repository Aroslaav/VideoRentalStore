using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRentalStore;

namespace VideoRentalStoreUI
{
    public partial class MainForm : Form
    {
        CInventory inventory;
        public MainForm()
        {
            InitializeComponent();
            inventory = CApp.GetApp.inventory;

            inventory.ListAllFilm();
            
            dgvInventory.DataSource = inventory.CurrentDataset;
            dgvOrders.DataSource = CApp.GetApp.orders;
            dgvCustomers.DataSource = CApp.GetApp.customers;
        }


        private void btnListAllFilms_Click(object sender, EventArgs e)
        {
            inventory.ListAllFilm();
            dgvInventory.DataSource = inventory.CurrentDataset;
        }

        private void btnListAllFilmsInStore_Click(object sender, EventArgs e)
        {
            inventory.ListAllFilmInStore();
            dgvInventory.DataSource = inventory.CurrentDataset;
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            using (NewFilmForm frm = new NewFilmForm())
            {
                frm.ShowDialog();
            }
        }

        private void btnRemoveFilm_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow !=null)
            {
                inventory.RemoveFilm((CFilm)dgvInventory.CurrentRow.DataBoundItem);
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            using (NewOrderForm frm = new NewOrderForm())
            {
                frm.ShowDialog();
            }
        }

        private void btnChangeTypeOfFilm_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow != null)
            {
                using (ChangeTypeOfFilmForm frm = new ChangeTypeOfFilmForm((CFilm)dgvInventory.CurrentRow.DataBoundItem))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void btnCloseOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null)
            {
                COrder order = (COrder)dgvOrders.CurrentRow.DataBoundItem;
                string message = order.EndRent();
                MessageBox.Show(message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
