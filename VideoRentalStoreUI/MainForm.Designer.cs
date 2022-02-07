
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
            this.btnChangeTypeOfFilm = new System.Windows.Forms.Button();
            this.btnListAllFilmsInStore = new System.Windows.Forms.Button();
            this.btnListAllFilms = new System.Windows.Forms.Button();
            this.btnRemoveFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.btnCloseOrder = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabInventoryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabInventoryPage);
            this.tabMain.Controls.Add(this.tabOrders);
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Location = new System.Drawing.Point(12, 10);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1318, 345);
            this.tabMain.TabIndex = 0;
            // 
            // tabInventoryPage
            // 
            this.tabInventoryPage.Controls.Add(this.btnChangeTypeOfFilm);
            this.tabInventoryPage.Controls.Add(this.btnListAllFilmsInStore);
            this.tabInventoryPage.Controls.Add(this.btnListAllFilms);
            this.tabInventoryPage.Controls.Add(this.btnRemoveFilm);
            this.tabInventoryPage.Controls.Add(this.btnAddFilm);
            this.tabInventoryPage.Controls.Add(this.dgvInventory);
            this.tabInventoryPage.Location = new System.Drawing.Point(4, 25);
            this.tabInventoryPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInventoryPage.Name = "tabInventoryPage";
            this.tabInventoryPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInventoryPage.Size = new System.Drawing.Size(1310, 316);
            this.tabInventoryPage.TabIndex = 0;
            this.tabInventoryPage.Text = "Inventory";
            this.tabInventoryPage.UseVisualStyleBackColor = true;
            // 
            // btnChangeTypeOfFilm
            // 
            this.btnChangeTypeOfFilm.Location = new System.Drawing.Point(753, 8);
            this.btnChangeTypeOfFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeTypeOfFilm.Name = "btnChangeTypeOfFilm";
            this.btnChangeTypeOfFilm.Size = new System.Drawing.Size(177, 23);
            this.btnChangeTypeOfFilm.TabIndex = 5;
            this.btnChangeTypeOfFilm.Text = "Change Type of Film";
            this.btnChangeTypeOfFilm.UseVisualStyleBackColor = true;
            this.btnChangeTypeOfFilm.Click += new System.EventHandler(this.btnChangeTypeOfFilm_Click);
            // 
            // btnListAllFilmsInStore
            // 
            this.btnListAllFilmsInStore.Location = new System.Drawing.Point(570, 8);
            this.btnListAllFilmsInStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListAllFilmsInStore.Name = "btnListAllFilmsInStore";
            this.btnListAllFilmsInStore.Size = new System.Drawing.Size(177, 23);
            this.btnListAllFilmsInStore.TabIndex = 4;
            this.btnListAllFilmsInStore.Text = "List all films in store ";
            this.btnListAllFilmsInStore.UseVisualStyleBackColor = true;
            this.btnListAllFilmsInStore.Click += new System.EventHandler(this.btnListAllFilmsInStore_Click);
            // 
            // btnListAllFilms
            // 
            this.btnListAllFilms.Location = new System.Drawing.Point(382, 8);
            this.btnListAllFilms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListAllFilms.Name = "btnListAllFilms";
            this.btnListAllFilms.Size = new System.Drawing.Size(177, 23);
            this.btnListAllFilms.TabIndex = 3;
            this.btnListAllFilms.Text = "List all films";
            this.btnListAllFilms.UseVisualStyleBackColor = true;
            this.btnListAllFilms.Click += new System.EventHandler(this.btnListAllFilms_Click);
            // 
            // btnRemoveFilm
            // 
            this.btnRemoveFilm.Location = new System.Drawing.Point(194, 8);
            this.btnRemoveFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFilm.Name = "btnRemoveFilm";
            this.btnRemoveFilm.Size = new System.Drawing.Size(177, 23);
            this.btnRemoveFilm.TabIndex = 2;
            this.btnRemoveFilm.Text = "Remove Film";
            this.btnRemoveFilm.UseVisualStyleBackColor = true;
            this.btnRemoveFilm.Click += new System.EventHandler(this.btnRemoveFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Location = new System.Drawing.Point(6, 8);
            this.btnAddFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(177, 23);
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
            this.dgvInventory.Location = new System.Drawing.Point(6, 36);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 29;
            this.dgvInventory.Size = new System.Drawing.Size(1298, 278);
            this.dgvInventory.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.btnCloseOrder);
            this.tabOrders.Controls.Add(this.btnCreateOrder);
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 25);
            this.tabOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabOrders.Size = new System.Drawing.Size(1310, 316);
            this.tabOrders.TabIndex = 1;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.Location = new System.Drawing.Point(194, 8);
            this.btnCloseOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(177, 23);
            this.btnCloseOrder.TabIndex = 4;
            this.btnCloseOrder.Text = "Close Order";
            this.btnCloseOrder.UseVisualStyleBackColor = true;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(6, 8);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(177, 23);
            this.btnCreateOrder.TabIndex = 3;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(6, 36);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 29;
            this.dgvOrders.Size = new System.Drawing.Size(1298, 278);
            this.dgvOrders.TabIndex = 1;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.dgvCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 25);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Size = new System.Drawing.Size(1310, 316);
            this.tabCustomers.TabIndex = 2;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(7, 36);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 29;
            this.dgvCustomers.Size = new System.Drawing.Size(1298, 278);
            this.dgvCustomers.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1232, 370);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 403);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Rental Store";
            this.tabMain.ResumeLayout(false);
            this.tabInventoryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
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
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseOrder;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnChangeTypeOfFilm;
    }
}

