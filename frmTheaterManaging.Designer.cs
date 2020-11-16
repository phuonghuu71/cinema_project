﻿namespace CSMS
{
    partial class frmTheaterManaging
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
            this.dtgvTheater = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.tbTheaterName = new System.Windows.Forms.TextBox();
            this.tbTheaterID = new System.Windows.Forms.TextBox();
            this.lbTheaterID = new System.Windows.Forms.Label();
            this.tbTheaterAddress = new System.Windows.Forms.TextBox();
            this.lbTheaterAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheater)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTheater
            // 
            this.dtgvTheater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTheater.Location = new System.Drawing.Point(12, 12);
            this.dtgvTheater.Name = "dtgvTheater";
            this.dtgvTheater.RowHeadersWidth = 51;
            this.dtgvTheater.RowTemplate.Height = 24;
            this.dtgvTheater.Size = new System.Drawing.Size(800, 500);
            this.dtgvTheater.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(915, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 60);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm rạp";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Red;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1121, 219);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 60);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit rạp";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1327, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 60);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa rạp";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbTheaterName
            // 
            this.lbTheaterName.AutoSize = true;
            this.lbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterName.ForeColor = System.Drawing.Color.White;
            this.lbTheaterName.Location = new System.Drawing.Point(909, 82);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Size = new System.Drawing.Size(123, 32);
            this.lbTheaterName.TabIndex = 9;
            this.lbTheaterName.Text = "Tên Rạp";
            // 
            // tbTheaterName
            // 
            this.tbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbTheaterName.Location = new System.Drawing.Point(1076, 79);
            this.tbTheaterName.Name = "tbTheaterName";
            this.tbTheaterName.Size = new System.Drawing.Size(451, 38);
            this.tbTheaterName.TabIndex = 10;
            // 
            // tbTheaterID
            // 
            this.tbTheaterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbTheaterID.Location = new System.Drawing.Point(1076, 9);
            this.tbTheaterID.Name = "tbTheaterID";
            this.tbTheaterID.ReadOnly = true;
            this.tbTheaterID.Size = new System.Drawing.Size(451, 38);
            this.tbTheaterID.TabIndex = 12;
            // 
            // lbTheaterID
            // 
            this.lbTheaterID.AutoSize = true;
            this.lbTheaterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterID.ForeColor = System.Drawing.Color.White;
            this.lbTheaterID.Location = new System.Drawing.Point(909, 12);
            this.lbTheaterID.Name = "lbTheaterID";
            this.lbTheaterID.Size = new System.Drawing.Size(113, 32);
            this.lbTheaterID.TabIndex = 11;
            this.lbTheaterID.Text = "Mã Rạp";
            // 
            // tbTheaterAddress
            // 
            this.tbTheaterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbTheaterAddress.Location = new System.Drawing.Point(1076, 149);
            this.tbTheaterAddress.Name = "tbTheaterAddress";
            this.tbTheaterAddress.Size = new System.Drawing.Size(451, 38);
            this.tbTheaterAddress.TabIndex = 14;
            // 
            // lbTheaterAddress
            // 
            this.lbTheaterAddress.AutoSize = true;
            this.lbTheaterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterAddress.ForeColor = System.Drawing.Color.White;
            this.lbTheaterAddress.Location = new System.Drawing.Point(909, 152);
            this.lbTheaterAddress.Name = "lbTheaterAddress";
            this.lbTheaterAddress.Size = new System.Drawing.Size(161, 32);
            this.lbTheaterAddress.TabIndex = 13;
            this.lbTheaterAddress.Text = "Địa chỉ Rạp";
            // 
            // frmTheaterManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tbTheaterAddress);
            this.Controls.Add(this.lbTheaterAddress);
            this.Controls.Add(this.tbTheaterID);
            this.Controls.Add(this.lbTheaterID);
            this.Controls.Add(this.tbTheaterName);
            this.Controls.Add(this.lbTheaterName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvTheater);
            this.Name = "frmTheaterManaging";
            this.Text = "frmTheaterManaging";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTheater;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbTheaterName;
        private System.Windows.Forms.TextBox tbTheaterName;
        private System.Windows.Forms.TextBox tbTheaterID;
        private System.Windows.Forms.Label lbTheaterID;
        private System.Windows.Forms.TextBox tbTheaterAddress;
        private System.Windows.Forms.Label lbTheaterAddress;
    }
}