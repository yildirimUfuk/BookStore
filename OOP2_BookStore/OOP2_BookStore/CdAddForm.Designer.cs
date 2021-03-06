﻿namespace OOP2_BookStore
{
    partial class CdAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CdAddForm));
			this.cmbCdType = new System.Windows.Forms.ComboBox();
			this.pbProductImage = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSale = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.lblSelectImage = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.tbPrice = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbSinger = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbCdType
			// 
			this.cmbCdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.cmbCdType.FormattingEnabled = true;
			this.cmbCdType.Items.AddRange(new object[] {
            "Romans",
            "Hard Rock",
            "Country"});
			this.cmbCdType.Location = new System.Drawing.Point(346, 222);
			this.cmbCdType.Margin = new System.Windows.Forms.Padding(4);
			this.cmbCdType.Name = "cmbCdType";
			this.cmbCdType.Size = new System.Drawing.Size(132, 28);
			this.cmbCdType.TabIndex = 2;
			// 
			// pbProductImage
			// 
			this.pbProductImage.Location = new System.Drawing.Point(345, 46);
			this.pbProductImage.Margin = new System.Windows.Forms.Padding(4);
			this.pbProductImage.Name = "pbProductImage";
			this.pbProductImage.Size = new System.Drawing.Size(133, 161);
			this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductImage.TabIndex = 29;
			this.pbProductImage.TabStop = false;
			this.pbProductImage.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label5.Location = new System.Drawing.Point(72, 95);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 20);
			this.label5.TabIndex = 28;
			this.label5.Text = "Sale";
			// 
			// tbSale
			// 
			this.tbSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSale.Location = new System.Drawing.Point(125, 92);
			this.tbSale.Margin = new System.Windows.Forms.Padding(4);
			this.tbSale.Name = "tbSale";
			this.tbSale.Size = new System.Drawing.Size(132, 26);
			this.tbSale.TabIndex = 1;
			this.tbSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(345, 258);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 42);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label8.Location = new System.Drawing.Point(23, 233);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 24;
			this.label8.Text = "description";
			// 
			// lblSelectImage
			// 
			this.lblSelectImage.AutoSize = true;
			this.lblSelectImage.Location = new System.Drawing.Point(355, 79);
			this.lblSelectImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSelectImage.Name = "lblSelectImage";
			this.lblSelectImage.Size = new System.Drawing.Size(108, 17);
			this.lblSelectImage.TabIndex = 22;
			this.lblSelectImage.Text = "SELECT IMAGE";
			this.lblSelectImage.Click += new System.EventHandler(this.LblSelectImage_Click);
			this.lblSelectImage.MouseLeave += new System.EventHandler(this.LblSelectImage_MouseLeave);
			this.lblSelectImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblSelectImage_MouseMove);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label9.Location = new System.Drawing.Point(298, 225);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 20);
			this.label9.TabIndex = 21;
			this.label9.Text = "type";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label7.Location = new System.Drawing.Point(68, 187);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 20);
			this.label7.TabIndex = 25;
			this.label7.Text = "price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label6.Location = new System.Drawing.Point(64, 141);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 18;
			this.label6.Text = "name";
			// 
			// tbDescription
			// 
			this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbDescription.Location = new System.Drawing.Point(125, 230);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(132, 22);
			this.tbDescription.TabIndex = 6;
			// 
			// tbPrice
			// 
			this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbPrice.Location = new System.Drawing.Point(125, 184);
			this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
			this.tbPrice.Name = "tbPrice";
			this.tbPrice.Size = new System.Drawing.Size(132, 26);
			this.tbPrice.TabIndex = 5;
			this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Decimal_KeyPress);
			// 
			// tbName
			// 
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbName.Location = new System.Drawing.Point(125, 138);
			this.tbName.Margin = new System.Windows.Forms.Padding(4);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(132, 26);
			this.tbName.TabIndex = 4;
			// 
			// tbSinger
			// 
			this.tbSinger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.tbSinger.Location = new System.Drawing.Point(125, 46);
			this.tbSinger.Margin = new System.Windows.Forms.Padding(4);
			this.tbSinger.Name = "tbSinger";
			this.tbSinger.Size = new System.Drawing.Size(132, 26);
			this.tbSinger.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.Location = new System.Drawing.Point(57, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 20);
			this.label1.TabIndex = 28;
			this.label1.Text = "Singer";
			// 
			// CdAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(538, 359);
			this.Controls.Add(this.cmbCdType);
			this.Controls.Add(this.pbProductImage);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbSinger);
			this.Controls.Add(this.tbSale);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblSelectImage);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.tbPrice);
			this.Controls.Add(this.tbName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "CdAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CdAddForm";
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCdType;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelectImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSinger;
        private System.Windows.Forms.Label label1;
    }
}