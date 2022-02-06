
namespace VideoRentalStoreUI
{
    partial class NewFilmForm
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblFilmType = new System.Windows.Forms.Label();
            this.cmbFilmType = new System.Windows.Forms.ComboBox();
            this.nudCopies = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(65, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(57, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Copies:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 37);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(364, 27);
            this.txtName.TabIndex = 4;
            // 
            // lblFilmType
            // 
            this.lblFilmType.AutoSize = true;
            this.lblFilmType.Location = new System.Drawing.Point(56, 102);
            this.lblFilmType.Name = "lblFilmType";
            this.lblFilmType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFilmType.Size = new System.Drawing.Size(75, 20);
            this.lblFilmType.TabIndex = 8;
            this.lblFilmType.Text = "Film Type:";
            // 
            // cmbFilmType
            // 
            this.cmbFilmType.FormattingEnabled = true;
            this.cmbFilmType.Location = new System.Drawing.Point(168, 102);
            this.cmbFilmType.Name = "cmbFilmType";
            this.cmbFilmType.Size = new System.Drawing.Size(151, 28);
            this.cmbFilmType.TabIndex = 10;
            // 
            // nudCopies
            // 
            this.nudCopies.Location = new System.Drawing.Point(168, 67);
            this.nudCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCopies.Name = "nudCopies";
            this.nudCopies.Size = new System.Drawing.Size(150, 27);
            this.nudCopies.TabIndex = 11;
            this.nudCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(290, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(178, 178);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 29);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // NewFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 219);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nudCopies);
            this.Controls.Add(this.cmbFilmType);
            this.Controls.Add(this.lblFilmType);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "NewFilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewFilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblFilmType;
        private System.Windows.Forms.ComboBox cmbFilmType;
        private System.Windows.Forms.NumericUpDown nudCopies;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}