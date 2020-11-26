namespace CSMS
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
            this.panelChooseScreen = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbScreen = new System.Windows.Forms.Label();
            this.panelChooseScreen.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lbTheaterName.Location = new System.Drawing.Point(5, 30);
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
            this.lbScreenName.Location = new System.Drawing.Point(5, 100);
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
            this.btnAddCinema.Location = new System.Drawing.Point(5, 104);
            this.btnAddCinema.Name = "btnAddCinema";
            this.btnAddCinema.Size = new System.Drawing.Size(280, 60);
            this.btnAddCinema.TabIndex = 5;
            this.btnAddCinema.Text = "Thêm phòng chiếu";
            this.btnAddCinema.UseVisualStyleBackColor = false;
            this.btnAddCinema.Click += new System.EventHandler(this.btnAddCinema_Click);
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(250, 30);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(322, 39);
            this.cbTheater.TabIndex = 6;
            this.cbTheater.SelectedIndexChanged += new System.EventHandler(this.cbTheater_SelectedIndexChanged);
            // 
            // cbScreen
            // 
            this.cbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Location = new System.Drawing.Point(250, 100);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(322, 39);
            this.cbScreen.TabIndex = 7;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // lbScreenInsert
            // 
            this.lbScreenInsert.AutoSize = true;
            this.lbScreenInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreenInsert.ForeColor = System.Drawing.Color.White;
            this.lbScreenInsert.Location = new System.Drawing.Point(5, 44);
            this.lbScreenInsert.Name = "lbScreenInsert";
            this.lbScreenInsert.Size = new System.Drawing.Size(293, 32);
            this.lbScreenInsert.TabIndex = 8;
            this.lbScreenInsert.Text = "Nhập tên phòng chiếu";
            // 
            // tbScreenInsertName
            // 
            this.tbScreenInsertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbScreenInsertName.Location = new System.Drawing.Point(297, 44);
            this.tbScreenInsertName.Name = "tbScreenInsertName";
            this.tbScreenInsertName.Size = new System.Drawing.Size(279, 38);
            this.tbScreenInsertName.TabIndex = 9;
            // 
            // btnSeatAdd
            // 
            this.btnSeatAdd.BackColor = System.Drawing.Color.Red;
            this.btnSeatAdd.FlatAppearance.BorderSize = 0;
            this.btnSeatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnSeatAdd.ForeColor = System.Drawing.Color.White;
            this.btnSeatAdd.Location = new System.Drawing.Point(5, 174);
            this.btnSeatAdd.Name = "btnSeatAdd";
            this.btnSeatAdd.Size = new System.Drawing.Size(572, 60);
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
            this.btnDeleteScreen.Location = new System.Drawing.Point(297, 104);
            this.btnDeleteScreen.Name = "btnDeleteScreen";
            this.btnDeleteScreen.Size = new System.Drawing.Size(280, 60);
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
            // panelChooseScreen
            // 
            this.panelChooseScreen.Controls.Add(this.lbTheaterName);
            this.panelChooseScreen.Controls.Add(this.cbTheater);
            this.panelChooseScreen.Controls.Add(this.lbScreenName);
            this.panelChooseScreen.Controls.Add(this.cbScreen);
            this.panelChooseScreen.Location = new System.Drawing.Point(770, 10);
            this.panelChooseScreen.Name = "panelChooseScreen";
            this.panelChooseScreen.Size = new System.Drawing.Size(580, 172);
            this.panelChooseScreen.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbScreen);
            this.panel1.Controls.Add(this.btnSeatAdd);
            this.panel1.Controls.Add(this.btnDeleteScreen);
            this.panel1.Controls.Add(this.btnAddCinema);
            this.panel1.Controls.Add(this.lbScreenInsert);
            this.panel1.Controls.Add(this.tbScreenInsertName);
            this.panel1.Location = new System.Drawing.Point(770, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 240);
            this.panel1.TabIndex = 14;
            // 
            // lbScreen
            // 
            this.lbScreen.AutoSize = true;
            this.lbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreen.ForeColor = System.Drawing.Color.White;
            this.lbScreen.Location = new System.Drawing.Point(5, 0);
            this.lbScreen.Name = "lbScreen";
            this.lbScreen.Size = new System.Drawing.Size(246, 32);
            this.lbScreen.TabIndex = 9;
            this.lbScreen.Text = "Nhập phòng chiếu";
            // 
            // frmSreenManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1380, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChooseScreen);
            this.Controls.Add(this.flpSeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSreenManaging";
            this.Text = "frmSreenManaging";
            this.Load += new System.EventHandler(this.frmSreenManaging_Load);
            this.panelChooseScreen.ResumeLayout(false);
            this.panelChooseScreen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelChooseScreen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbScreen;
    }
}