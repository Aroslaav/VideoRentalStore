
namespace VideoRentalStoreUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabInventoryPage = new System.Windows.Forms.TabPage();
            this.btnListAllFilmsInStore = new System.Windows.Forms.Button();
            this.btnListAllFilms = new System.Windows.Forms.Button();
            this.btnRemoveFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabInventoryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabInventoryPage);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1318, 431);
            this.tabMain.TabIndex = 0;
            // 
            // tabInventoryPage
            // 
            this.tabInventoryPage.Controls.Add(this.btnListAllFilmsInStore);
            this.tabInventoryPage.Controls.Add(this.btnListAllFilms);
            this.tabInventoryPage.Controls.Add(this.btnRemoveFilm);
            this.tabInventoryPage.Controls.Add(this.btnAddFilm);
            this.tabInventoryPage.Controls.Add(this.dgvInventory);
            this.tabInventoryPage.Location = new System.Drawing.Point(4, 29);
            this.tabInventoryPage.Name = "tabInventoryPage";
            this.tabInventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventoryPage.Size = new System.Drawing.Size(1310, 398);
            this.tabInventoryPage.TabIndex = 0;
            this.tabInventoryPage.Text = "Inventory";
            this.tabInventoryPage.UseVisualStyleBackColor = true;
            // 
            // btnListAllFilmsInStore
            // 
            this.btnListAllFilmsInStore.Location = new System.Drawing.Point(570, 10);
            this.btnListAllFilmsInStore.Name = "btnListAllFilmsInStore";
            this.btnListAllFilmsInStore.Size = new System.Drawing.Size(177, 29);
            this.btnListAllFilmsInStore.TabIndex = 4;
            this.btnListAllFilmsInStore.Text = "List all films in store ";
            this.btnListAllFilmsInStore.UseVisualStyleBackColor = true;
            this.btnListAllFilmsInStore.Click += new System.EventHandler(this.btnListAllFilmsInStore_Click);
            // 
            // btnListAllFilms
            // 
            this.btnListAllFilms.Location = new System.Drawing.Point(382, 10);
            this.btnListAllFilms.Name = "btnListAllFilms";
            this.btnListAllFilms.Size = new System.Drawing.Size(177, 29);
            this.btnListAllFilms.TabIndex = 3;
            this.btnListAllFilms.Text = "List all films";
            this.btnListAllFilms.UseVisualStyleBackColor = true;
            this.btnListAllFilms.Click += new System.EventHandler(this.btnListAllFilms_Click);
            // 
            // btnRemoveFilm
            // 
            this.btnRemoveFilm.Location = new System.Drawing.Point(194, 10);
            this.btnRemoveFilm.Name = "btnRemoveFilm";
            this.btnRemoveFilm.Size = new System.Drawing.Size(177, 29);
            this.btnRemoveFilm.TabIndex = 2;
            this.btnRemoveFilm.Text = "Remove Film";
            this.btnRemoveFilm.UseVisualStyleBackColor = true;
            this.btnRemoveFilm.Click += new System.EventHandler(this.btnRemoveFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(6, 10);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(177, 29);
            this.btnAddFilm.TabIndex = 1;
            this.btnAddFilm.Text = "Add Film";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(6, 45);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 29;
            this.dgvInventory.Size = new System.Drawing.Size(1298, 347);
            this.dgvInventory.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1310, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1232, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 504);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Rental Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabInventoryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabInventoryPage;
        private System.Windows.Forms.Button btnListAllFilmsInStore;
        private System.Windows.Forms.Button btnListAllFilms;
        private System.Windows.Forms.Button btnRemoveFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClose;
    }
}

