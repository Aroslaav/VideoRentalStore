﻿using System;
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
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = inventory.CurrentDataset;
            dgvInventory.Update();

            dgvOrders.DataSource = CApp.GetApp.orders;
            dgvCustomers.DataSource = CApp.GetApp.customers;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnListAllFilms_Click(object sender, EventArgs e)
        {

            // DataSet ds= CHelper.ToDataSet(inventory.ListAllFilm());
            // dgvInventory.DataSource = ds;
            inventory.ListAllFilm();
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = inventory.CurrentDataset;
            dgvInventory.Update();
        }

        private void btnListAllFilmsInStore_Click(object sender, EventArgs e)
        {
            inventory.ListAllFilmInStore();
            dgvInventory.DataSource = null;
            dgvInventory.DataSource = inventory.CurrentDataset;
            dgvInventory.Update();
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            using (NewFilmForm frm = new NewFilmForm())
            {
                if (DialogResult.OK == frm.ShowDialog())
                {
                    dgvInventory.DataSource = inventory.CurrentDataset;
                    dgvInventory.Update();
                }
            }
            
        }

        private void btnRemoveFilm_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow !=null)
            {
                inventory.RemoveFilm((CFilm)dgvInventory.CurrentRow.DataBoundItem);
                dgvInventory.DataSource = null;
                dgvInventory.DataSource = inventory.CurrentDataset;
                dgvInventory.Update();
                //dgvInventory.Rows.RemoveAt(dgvInventory.Rows.Count-2);
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

                    if (DialogResult.OK == frm.DialogResult)
                    {
                        dgvInventory.DataSource = null;
                        dgvInventory.DataSource = inventory.CurrentDataset;
                        dgvInventory.Update();
                    }
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
    }
}
