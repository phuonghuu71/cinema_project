﻿namespace CSMS
{
    partial class frmSreenManaging
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
            this.components = new System.ComponentModel.Container();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.btnAddCinema = new System.Windows.Forms.Button();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.lbScreenInsert = new System.Windows.Forms.Label();
            this.tbScreenInsertName = new System.Windows.Forms.TextBox();
            this.btnSeatAdd = new System.Windows.Forms.Button();
            this.btnDeleteScreen = new System.Windows.Forms.Button();
            this.beAddScreen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beDeleteScreen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beSeatAdd = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // flpSeat
            // 
            this.flpSeat.Location = new System.Drawing.Point(10, 10);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(750, 700);
            this.flpSeat.TabIndex = 0;
            // 
            // lbTheaterName
            // 
            this.lbTheaterName.AutoSize = true;
            this.lbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterName.ForeColor = System.Drawing.Color.White;
            this.lbTheaterName.Location = new System.Drawing.Point(790, 30);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Size = new System.Drawing.Size(123, 32);
            this.lbTheaterName.TabIndex = 3;
            this.lbTheaterName.Text = "Tên Rạp";
            // 
            // lbScreenName
            // 
            this.lbScreenName.AutoSize = true;
            this.lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreenName.ForeColor = System.Drawing.Color.White;
            this.lbScreenName.Location = new System.Drawing.Point(790, 101);
            this.lbScreenName.Name = "lbScreenName";
            this.lbScreenName.Size = new System.Drawing.Size(227, 32);
            this.lbScreenName.TabIndex = 4;
            this.lbScreenName.Text = "Tên phòng chiếu";
            // 
            // btnAddCinema
            // 
            this.btnAddCinema.BackColor = System.Drawing.Color.Red;
            this.btnAddCinema.FlatAppearance.BorderSize = 0;
            this.btnAddCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnAddCinema.ForeColor = System.Drawing.Color.White;
            this.btnAddCinema.Location = new System.Drawing.Point(796, 288);
            this.btnAddCinema.Name = "btnAddCinema";
            this.btnAddCinema.Size = new System.Drawing.Size(300, 60);
            this.btnAddCinema.TabIndex = 5;
            this.btnAddCinema.Text = "Thêm phòng chiếu";
            this.btnAddCinema.UseVisualStyleBackColor = false;
            this.btnAddCinema.Click += new System.EventHandler(this.btnAddCinema_Click);
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(1030, 30);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(426, 39);
            this.cbTheater.TabIndex = 6;
            this.cbTheater.SelectedIndexChanged += new System.EventHandler(this.cbTheater_SelectedIndexChanged);
            // 
            // cbScreen
            // 
            this.cbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Location = new System.Drawing.Point(1030, 101);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(426, 39);
            this.cbScreen.TabIndex = 7;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // lbScreenInsert
            // 
            this.lbScreenInsert.AutoSize = true;
            this.lbScreenInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreenInsert.ForeColor = System.Drawing.Color.White;
            this.lbScreenInsert.Location = new System.Drawing.Point(790, 172);
            this.lbScreenInsert.Name = "lbScreenInsert";
            this.lbScreenInsert.Size = new System.Drawing.Size(416, 32);
            this.lbScreenInsert.TabIndex = 8;
            this.lbScreenInsert.Text = "Nhập tên phòng chiếu cần thêm";
            // 
            // tbScreenInsertName
            // 
            this.tbScreenInsertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbScreenInsertName.Location = new System.Drawing.Point(1212, 172);
            this.tbScreenInsertName.Name = "tbScreenInsertName";
            this.tbScreenInsertName.Size = new System.Drawing.Size(244, 38);
            this.tbScreenInsertName.TabIndex = 9;
            // 
            // btnSeatAdd
            // 
            this.btnSeatAdd.BackColor = System.Drawing.Color.Red;
            this.btnSeatAdd.FlatAppearance.BorderSize = 0;
            this.btnSeatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnSeatAdd.ForeColor = System.Drawing.Color.White;
            this.btnSeatAdd.Location = new System.Drawing.Point(796, 377);
            this.btnSeatAdd.Name = "btnSeatAdd";
            this.btnSeatAdd.Size = new System.Drawing.Size(660, 60);
            this.btnSeatAdd.TabIndex = 11;
            this.btnSeatAdd.Text = "Thêm ghế";
            this.btnSeatAdd.UseVisualStyleBackColor = false;
            this.btnSeatAdd.Click += new System.EventHandler(this.btnSeatAdd_Click);
            // 
            // btnDeleteScreen
            // 
            this.btnDeleteScreen.BackColor = System.Drawing.Color.Red;
            this.btnDeleteScreen.FlatAppearance.BorderSize = 0;
            this.btnDeleteScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnDeleteScreen.ForeColor = System.Drawing.Color.White;
            this.btnDeleteScreen.Location = new System.Drawing.Point(1156, 288);
            this.btnDeleteScreen.Name = "btnDeleteScreen";
            this.btnDeleteScreen.Size = new System.Drawing.Size(300, 60);
            this.btnDeleteScreen.TabIndex = 12;
            this.btnDeleteScreen.Text = "Xóa phòng chiếu";
            this.btnDeleteScreen.UseVisualStyleBackColor = false;
            this.btnDeleteScreen.Click += new System.EventHandler(this.btnDeleteScreen_Click);
            // 
            // beAddScreen
            // 
            this.beAddScreen.ElipseRadius = 15;
            this.beAddScreen.TargetControl = this.btnAddCinema;
            // 
            // beDeleteScreen
            // 
            this.beDeleteScreen.ElipseRadius = 15;
            this.beDeleteScreen.TargetControl = this.btnDeleteScreen;
            // 
            // beSeatAdd
            // 
            this.beSeatAdd.ElipseRadius = 15;
            this.beSeatAdd.TargetControl = this.btnSeatAdd;
            // 
            // frmSreenManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.btnDeleteScreen);
            this.Controls.Add(this.btnSeatAdd);
            this.Controls.Add(this.tbScreenInsertName);
            this.Controls.Add(this.lbScreenInsert);
            this.Controls.Add(this.cbScreen);
            this.Controls.Add(this.cbTheater);
            this.Controls.Add(this.btnAddCinema);
            this.Controls.Add(this.lbScreenName);
            this.Controls.Add(this.lbTheaterName);
            this.Controls.Add(this.flpSeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSreenManaging";
            this.Text = "frmSreenManaging";
            this.Load += new System.EventHandler(this.frmSreenManaging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Label lbTheaterName;
        private System.Windows.Forms.Label lbScreenName;
        private System.Windows.Forms.Button btnAddCinema;
        private System.Windows.Forms.ComboBox cbTheater;
        private System.Windows.Forms.ComboBox cbScreen;
        private System.Windows.Forms.Label lbScreenInsert;
        private System.Windows.Forms.TextBox tbScreenInsertName;
        private System.Windows.Forms.Button btnSeatAdd;
        private System.Windows.Forms.Button btnDeleteScreen;
        private Bunifu.Framework.UI.BunifuElipse beAddScreen;
        private Bunifu.Framework.UI.BunifuElipse beDeleteScreen;
        private Bunifu.Framework.UI.BunifuElipse beSeatAdd;
    }
}