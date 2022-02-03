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
    public partial class NewFilmForm : Form
    {
        CInventory Inventory;
        public NewFilmForm(CInventory inventory)
        {
            InitializeComponent();
            Inventory = inventory;
            cmbFilmType.DataSource = Enum.GetValues(typeof(FilmType));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            FilmType filmType;
            Enum.TryParse<FilmType>(cmbFilmType.SelectedValue.ToString(), out filmType);
            CFilm newFilm = new CRegularFilm(txtName.Text);
            switch (filmType)
            {
                case FilmType.NewRelease:
                    newFilm = new CNewReleaseFilm(txtName.Text);
                    break;
                case FilmType.OldFilm:
                    newFilm = new COldFilm(txtName.Text);
                    break;
                case FilmType.RegularFilm:
                    newFilm = new CRegularFilm(txtName.Text);
                    break;
            }
            
            newFilm.Copies = (int)nudCopies.Value;

            Inventory.AddFilm(newFilm);
        }
    }
}
