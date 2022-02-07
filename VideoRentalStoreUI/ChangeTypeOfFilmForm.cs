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
    public partial class ChangeTypeOfFilmForm : Form
    {
        CFilm Film;
        public ChangeTypeOfFilmForm( CFilm film )
        {
            InitializeComponent();
            Film = film;

            cmbNewType.DataSource = Enum.GetValues(typeof(FilmType)); 
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FilmType type;
            Enum.TryParse<FilmType>(cmbNewType.SelectedValue.ToString(), out type);
            CApp.GetApp.inventory.ChangeTypeOfFilm(Film, type);
            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
