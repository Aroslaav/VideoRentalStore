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

        public NewFilmForm()
        {
            InitializeComponent();

            cmbFilmType.DataSource = Enum.GetValues(typeof(FilmType));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length==0)
            {
                MessageBox.Show("Please fill the name.");
                return;
            }    
            DialogResult = DialogResult.OK;
            FilmType filmType;
            Enum.TryParse<FilmType>(cmbFilmType.SelectedValue.ToString(), out filmType);
            CFilm newFilm = null;

            switch (filmType)
            {
                case FilmType.NewRelease:
                    newFilm = new CNewReleaseFilm() { Title = txtName.Text };//newFilm;//CFilm.Convert<CNewReleaseFilm>(newFilm);
                    break;
                case FilmType.OldFilm:
                    newFilm = new COldFilm() { Title = txtName.Text };//(COldFilm)newFilm; 
                    break;
                case FilmType.RegularFilm:
                    newFilm = new CRegularFilm() { Title = txtName.Text };//(CRegularFilm)newFilm; 
                    break;
            }
            
            newFilm.Copies = (int)nudCopies.Value;

           CApp.GetApp.inventory.AddFilm(newFilm);
        }
    }
}
