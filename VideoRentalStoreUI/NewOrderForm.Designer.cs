
namespace VideoRentalStoreUI
{
    partial class NewOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudRentDays = new System.Windows.Forms.NumericUpDown();
            this.lblSelectFilms = new System.Windows.Forms.Label();
            this.cblFilms = new System.Windows.Forms.CheckedListBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentDays)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRentDays
            // 
            this.nudRentDays.Location = new System.Drawing.Point(169, 79);
            this.nudRentDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRentDays.Name = "nudRentDays";
            this.nudRentDays.Size = new System.Drawing.Size(150, 27);
            this.nudRentDays.TabIndex = 55;
            this.nudRentDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSelectFilms
            // 
            this.lblSelectFilms.AutoSize = true;
            this.lblSelectFilms.Location = new System.Drawing.Point(44, 136);
            this.lblSelectFilms.Name = "lblSelectFilms";
            this.lblSelectFilms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSelectFilms.Size = new System.Drawing.Size(86, 20);
            this.lblSelectFilms.TabIndex = 54;
            this.lblSelectFilms.Text = "SelectFilms:";
            // 
            // cblFilms
            // 
            this.cblFilms.FormattingEnabled = true;
            this.cblFilms.Location = new System.Drawing.Point(44, 159);
            this.cblFilms.Name = "cblFilms";
            this.cblFilms.Size = new System.Drawing.Size(713, 224);
            this.cblFilms.TabIndex = 53;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(88, 79);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEndDate.Size = new System.Drawing.Size(78, 20);
            this.lblEndDate.TabIndex = 52;
            this.lblEndDate.Text = "Rent Days:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(169, 11);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(254, 28);
            this.cmbCustomer.TabIndex = 51;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(400, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(272, 411);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 49;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(88, 14);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomer.Size = new System.Drawing.Size(75, 20);
            this.lblCustomer.TabIndex = 48;
            this.lblCustomer.Text = "Customer:";
            // 
            // Form12cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudRentDays);
            this.Controls.Add(this.lblSelectFilms);
            this.Controls.Add(this.cblFilms);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCustomer);
            this.Name = "Form12cs";
            this.Text = "Form12cs";
            ((System.ComponentModel.ISupportInitialize)(this.nudRentDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRentDays;
        private System.Windows.Forms.Label lblSelectFilms;
        private System.Windows.Forms.CheckedListBox cblFilms;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCustomer;
    }
}