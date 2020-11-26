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
            this.dtgvShowtime = new System.Windows.Forms.DataGridView();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.dtpShowtime = new System.Windows.Forms.DateTimePicker();
            this.lbShowtime = new System.Windows.Forms.Label();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.btnAddShowtime = new System.Windows.Forms.Button();
            this.btnEditShowtime = new System.Windows.Forms.Button();
            this.btnDeleteShowtime = new System.Windows.Forms.Button();
            this.beAdd = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beEdit = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beDelete = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.cbMovie.Location = new System.Drawing.Point(1027, 158);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(341, 39);
            this.cbMovie.TabIndex = 1;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbMovieName.ForeColor = System.Drawing.Color.White;
            this.lbMovieName.Location = new System.Drawing.Point(786, 161);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(133, 32);
            this.lbMovieName.TabIndex = 2;
            this.lbMovieName.Text = "Tên phim";
            // 
            // dtpShowtime
            // 
            this.dtpShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpShowtime.Location = new System.Drawing.Point(1027, 231);
            this.dtpShowtime.Name = "dtpShowtime";
            this.dtpShowtime.Size = new System.Drawing.Size(341, 38);
            this.dtpShowtime.TabIndex = 3;
            // 
            // lbShowtime
            // 
            this.lbShowtime.AutoSize = true;
            this.lbShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbShowtime.ForeColor = System.Drawing.Color.White;
            this.lbShowtime.Location = new System.Drawing.Point(786, 231);
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
            this.lbTheaterName.Location = new System.Drawing.Point(786, 21);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Size = new System.Drawing.Size(143, 32);
            this.lbTheaterName.TabIndex = 6;
            this.lbTheaterName.Text = "Rạp chiếu";
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(1027, 12);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(341, 39);
            this.cbTheater.TabIndex = 5;
            this.cbTheater.SelectedIndexChanged += new System.EventHandler(this.cbTheater_SelectedIndexChanged);
            // 
            // lbScreenName
            // 
            this.lbScreenName.AutoSize = true;
            this.lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreenName.ForeColor = System.Drawing.Color.White;
            this.lbScreenName.Location = new System.Drawing.Point(786, 91);
            this.lbScreenName.Name = "lbScreenName";
            this.lbScreenName.Size = new System.Drawing.Size(227, 32);
            this.lbScreenName.TabIndex = 8;
            this.lbScreenName.Text = "Tên phòng chiếu";
            // 
            // cbScreen
            // 
            this.cbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Location = new System.Drawing.Point(1027, 85);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(341, 39);
            this.cbScreen.TabIndex = 7;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // btnAddShowtime
            // 
            this.btnAddShowtime.BackColor = System.Drawing.Color.Red;
            this.btnAddShowtime.FlatAppearance.BorderSize = 0;
            this.btnAddShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnAddShowtime.ForeColor = System.Drawing.Color.White;
            this.btnAddShowtime.Location = new System.Drawing.Point(786, 315);
            this.btnAddShowtime.Name = "btnAddShowtime";
            this.btnAddShowtime.Size = new System.Drawing.Size(250, 60);
            this.btnAddShowtime.TabIndex = 9;
            this.btnAddShowtime.Text = "Thêm lịch chiếu";
            this.btnAddShowtime.UseVisualStyleBackColor = false;
            this.btnAddShowtime.Click += new System.EventHandler(this.btnAddShowtime_Click);
            // 
            // btnEditShowtime
            // 
            this.btnEditShowtime.BackColor = System.Drawing.Color.Red;
            this.btnEditShowtime.FlatAppearance.BorderSize = 0;
            this.btnEditShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnEditShowtime.ForeColor = System.Drawing.Color.White;
            this.btnEditShowtime.Location = new System.Drawing.Point(1118, 315);
            this.btnEditShowtime.Name = "btnEditShowtime";
            this.btnEditShowtime.Size = new System.Drawing.Size(250, 60);
            this.btnEditShowtime.TabIndex = 10;
            this.btnEditShowtime.Text = "Sửa lịch chiếu";
            this.btnEditShowtime.UseVisualStyleBackColor = false;
            // 
            // btnDeleteShowtime
            // 
            this.btnDeleteShowtime.BackColor = System.Drawing.Color.Red;
            this.btnDeleteShowtime.FlatAppearance.BorderSize = 0;
            this.btnDeleteShowtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.btnDeleteShowtime.ForeColor = System.Drawing.Color.White;
            this.btnDeleteShowtime.Location = new System.Drawing.Point(786, 381);
            this.btnDeleteShowtime.Name = "btnDeleteShowtime";
            this.btnDeleteShowtime.Size = new System.Drawing.Size(582, 60);
            this.btnDeleteShowtime.TabIndex = 11;
            this.btnDeleteShowtime.Text = "Xóa lịch chiếu";
            this.btnDeleteShowtime.UseVisualStyleBackColor = false;
            // 
            // beAdd
            // 
            this.beAdd.ElipseRadius = 15;
            this.beAdd.TargetControl = this.btnAddShowtime;
            // 
            // beEdit
            // 
            this.beEdit.ElipseRadius = 15;
            this.beEdit.TargetControl = this.btnEditShowtime;
            // 
            // beDelete
            // 
            this.beDelete.ElipseRadius = 15;
            this.beDelete.TargetControl = this.btnDeleteShowtime;
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
        private System.Windows.Forms.Button btnAddShowtime;
        private System.Windows.Forms.Button btnEditShowtime;
        private System.Windows.Forms.Button btnDeleteShowtime;
        private Bunifu.Framework.UI.BunifuElipse beAdd;
        private Bunifu.Framework.UI.BunifuElipse beEdit;
        private Bunifu.Framework.UI.BunifuElipse beDelete;
    }
}