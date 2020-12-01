namespace CSMS
{
    partial class frmShowtimeManaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowtimeManaging));
            this.dtgvShowtime = new System.Windows.Forms.DataGridView();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.dtpShowtime = new System.Windows.Forms.DateTimePicker();
            this.lbShowtime = new System.Windows.Forms.Label();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.beAdd = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beEdit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beDelete = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mummyTextbox = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtpShowtimeDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddShowtime = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteShowtime = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditShowtime = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvShowtime
            // 
            this.dtgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvShowtime.Location = new System.Drawing.Point(12, 12);
            this.dtgvShowtime.Name = "dtgvShowtime";
            this.dtgvShowtime.RowHeadersWidth = 51;
            this.dtgvShowtime.RowTemplate.Height = 24;
            this.dtgvShowtime.Size = new System.Drawing.Size(760, 480);
            this.dtgvShowtime.TabIndex = 0;
            // 
            // cbMovie
            // 
            this.cbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(1021, 145);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(340, 39);
            this.cbMovie.TabIndex = 1;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbMovieName.ForeColor = System.Drawing.Color.White;
            this.lbMovieName.Location = new System.Drawing.Point(788, 144);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(133, 32);
            this.lbMovieName.TabIndex = 2;
            this.lbMovieName.Text = "Tên phim";
            // 
            // dtpShowtime
            // 
            this.dtpShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpShowtime.Location = new System.Drawing.Point(1021, 278);
            this.dtpShowtime.Name = "dtpShowtime";
            this.dtpShowtime.Size = new System.Drawing.Size(340, 38);
            this.dtpShowtime.TabIndex = 3;
            // 
            // lbShowtime
            // 
            this.lbShowtime.AutoSize = true;
            this.lbShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbShowtime.ForeColor = System.Drawing.Color.White;
            this.lbShowtime.Location = new System.Drawing.Point(788, 276);
            this.lbShowtime.Name = "lbShowtime";
            this.lbShowtime.Size = new System.Drawing.Size(136, 32);
            this.lbShowtime.TabIndex = 4;
            this.lbShowtime.Text = "Giờ chiếu";
            // 
            // lbTheaterName
            // 
            this.lbTheaterName.AutoSize = true;
            this.lbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbTheaterName.ForeColor = System.Drawing.Color.White;
            this.lbTheaterName.Location = new System.Drawing.Point(788, 12);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Size = new System.Drawing.Size(143, 32);
            this.lbTheaterName.TabIndex = 6;
            this.lbTheaterName.Text = "Rạp chiếu";
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(1021, 11);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(340, 39);
            this.cbTheater.TabIndex = 5;
            this.cbTheater.SelectedIndexChanged += new System.EventHandler(this.cbTheater_SelectedIndexChanged);
            // 
            // lbScreenName
            // 
            this.lbScreenName.AutoSize = true;
            this.lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreenName.ForeColor = System.Drawing.Color.White;
            this.lbScreenName.Location = new System.Drawing.Point(788, 78);
            this.lbScreenName.Name = "lbScreenName";
            this.lbScreenName.Size = new System.Drawing.Size(227, 32);
            this.lbScreenName.TabIndex = 8;
            this.lbScreenName.Text = "Tên phòng chiếu";
            // 
            // cbScreen
            // 
            this.cbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Location = new System.Drawing.Point(1021, 78);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(340, 39);
            this.cbScreen.TabIndex = 7;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // beAdd
            // 
            this.beAdd.ElipseRadius = 15;
            this.beAdd.TargetControl = this;
            // 
            // beEdit
            // 
            this.beEdit.ElipseRadius = 15;
            this.beEdit.TargetControl = this;
            // 
            // beDelete
            // 
            this.beDelete.ElipseRadius = 15;
            this.beDelete.TargetControl = this;
            // 
            // mummyTextbox
            // 
            this.mummyTextbox.Location = new System.Drawing.Point(1307, 409);
            this.mummyTextbox.Name = "mummyTextbox";
            this.mummyTextbox.Size = new System.Drawing.Size(0, 22);
            this.mummyTextbox.TabIndex = 12;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(788, 210);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(157, 32);
            this.lbDate.TabIndex = 14;
            this.lbDate.Text = "Ngày chiếu";
            // 
            // dtpShowtimeDate
            // 
            this.dtpShowtimeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpShowtimeDate.Location = new System.Drawing.Point(1021, 212);
            this.dtpShowtimeDate.Name = "dtpShowtimeDate";
            this.dtpShowtimeDate.Size = new System.Drawing.Size(340, 38);
            this.dtpShowtimeDate.TabIndex = 13;
            // 
            // btnAddShowtime
            // 
            this.btnAddShowtime.ActiveBorderThickness = 1;
            this.btnAddShowtime.ActiveCornerRadius = 15;
            this.btnAddShowtime.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddShowtime.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddShowtime.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnAddShowtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnAddShowtime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddShowtime.BackgroundImage")));
            this.btnAddShowtime.ButtonText = "THÊM";
            this.btnAddShowtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddShowtime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShowtime.ForeColor = System.Drawing.Color.White;
            this.btnAddShowtime.IdleBorderThickness = 1;
            this.btnAddShowtime.IdleCornerRadius = 15;
            this.btnAddShowtime.IdleFillColor = System.Drawing.Color.Red;
            this.btnAddShowtime.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnAddShowtime.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAddShowtime.Location = new System.Drawing.Point(921, 341);
            this.btnAddShowtime.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddShowtime.Name = "btnAddShowtime";
            this.btnAddShowtime.Size = new System.Drawing.Size(140, 60);
            this.btnAddShowtime.TabIndex = 32;
            this.btnAddShowtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddShowtime.Click += new System.EventHandler(this.btnAddShowtime_Click);
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.ActiveBorderThickness = 1;
            this.btnDeleteShowtime.ActiveCornerRadius = 15;
            this.btnDeleteShowtime.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteShowtime.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteShowtime.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnDeleteShowtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnDeleteShowtime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteShowtime.BackgroundImage")));
            this.btnDeleteShowtime.ButtonText = "XÓA";
            this.btnDeleteShowtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteShowtime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteShowtime.ForeColor = System.Drawing.Color.White;
            this.btnDeleteShowtime.IdleBorderThickness = 1;
            this.btnDeleteShowtime.IdleCornerRadius = 15;
            this.btnDeleteShowtime.IdleFillColor = System.Drawing.Color.Red;
            this.btnDeleteShowtime.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnDeleteShowtime.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnDeleteShowtime.Location = new System.Drawing.Point(1221, 341);
            this.btnDeleteShowtime.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(140, 60);
            this.btnDeleteShowtime.TabIndex = 35;
            this.btnDeleteShowtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteShowtime.Click += new System.EventHandler(this.btnDeleteShowtime_Click);
            // 
            // btnEditShowtime
            // 
            this.btnEditShowtime.ActiveBorderThickness = 1;
            this.btnEditShowtime.ActiveCornerRadius = 15;
            this.btnEditShowtime.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditShowtime.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditShowtime.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnEditShowtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnEditShowtime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditShowtime.BackgroundImage")));
            this.btnEditShowtime.ButtonText = "SỬA";
            this.btnEditShowtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditShowtime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShowtime.ForeColor = System.Drawing.Color.White;
            this.btnEditShowtime.IdleBorderThickness = 1;
            this.btnEditShowtime.IdleCornerRadius = 15;
            this.btnEditShowtime.IdleFillColor = System.Drawing.Color.Red;
            this.btnEditShowtime.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnEditShowtime.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnEditShowtime.Location = new System.Drawing.Point(1071, 341);
            this.btnEditShowtime.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditShowtime.Name = "btnEditShowtime";
            this.btnEditShowtime.Size = new System.Drawing.Size(140, 60);
            this.btnEditShowtime.TabIndex = 34;
            this.btnEditShowtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditShowtime.Click += new System.EventHandler(this.btnEditShowtime_Click);
            // 
            // frmShowtimeManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1380, 800);
            this.Controls.Add(this.btnDeleteShowtime);
            this.Controls.Add(this.btnEditShowtime);
            this.Controls.Add(this.btnAddShowtime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.dtpShowtimeDate);
            this.Controls.Add(this.mummyTextbox);
            this.Controls.Add(this.lbScreenName);
            this.Controls.Add(this.cbScreen);
            this.Controls.Add(this.lbTheaterName);
            this.Controls.Add(this.cbTheater);
            this.Controls.Add(this.lbShowtime);
            this.Controls.Add(this.dtpShowtime);
            this.Controls.Add(this.lbMovieName);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.dtgvShowtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowtimeManaging";
            this.Text = "frmShowtimeManaging";
            this.Load += new System.EventHandler(this.frmShowtimeManaging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvShowtime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvShowtime;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.DateTimePicker dtpShowtime;
        private System.Windows.Forms.Label lbShowtime;
        private System.Windows.Forms.Label lbTheaterName;
        private System.Windows.Forms.ComboBox cbTheater;
        private System.Windows.Forms.Label lbScreenName;
        private System.Windows.Forms.ComboBox cbScreen;
        private Bunifu.Framework.UI.BunifuElipse beAdd;
        private Bunifu.Framework.UI.BunifuElipse beEdit;
        private Bunifu.Framework.UI.BunifuElipse beDelete;
        private System.Windows.Forms.TextBox mummyTextbox;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dtpShowtimeDate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddShowtime;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteShowtime;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditShowtime;
    }
}