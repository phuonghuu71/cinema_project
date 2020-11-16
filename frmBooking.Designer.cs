namespace CSMS
{
    partial class frmBooking
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
            this.panelBooking = new System.Windows.Forms.Panel();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lbDateBooking = new System.Windows.Forms.Label();
            this.dtpDateBooking = new System.Windows.Forms.DateTimePicker();
            this.btnBooking = new System.Windows.Forms.Button();
            this.cbMovieBooking = new System.Windows.Forms.ComboBox();
            this.cbTimeBooking = new System.Windows.Forms.ComboBox();
            this.lbFilmBooking = new System.Windows.Forms.Label();
            this.lbTimeBooking = new System.Windows.Forms.Label();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTheater = new System.Windows.Forms.Panel();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.panelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelTheater.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBooking
            // 
            this.panelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panelBooking.Controls.Add(this.pbPoster);
            this.panelBooking.Controls.Add(this.panelLeft);
            this.panelBooking.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBooking.Location = new System.Drawing.Point(0, 0);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(950, 953);
            this.panelBooking.TabIndex = 1;
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(33, 22);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(350, 346);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 17;
            this.pbPoster.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lbDateBooking);
            this.panelLeft.Controls.Add(this.dtpDateBooking);
            this.panelLeft.Controls.Add(this.btnBooking);
            this.panelLeft.Controls.Add(this.cbMovieBooking);
            this.panelLeft.Controls.Add(this.cbTimeBooking);
            this.panelLeft.Controls.Add(this.lbFilmBooking);
            this.panelLeft.Controls.Add(this.lbTimeBooking);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLeft.Location = new System.Drawing.Point(0, 374);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(950, 579);
            this.panelLeft.TabIndex = 16;
            // 
            // lbDateBooking
            // 
            this.lbDateBooking.AutoSize = true;
            this.lbDateBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateBooking.ForeColor = System.Drawing.Color.White;
            this.lbDateBooking.Location = new System.Drawing.Point(33, 150);
            this.lbDateBooking.Name = "lbDateBooking";
            this.lbDateBooking.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbDateBooking.Size = new System.Drawing.Size(157, 52);
            this.lbDateBooking.TabIndex = 12;
            this.lbDateBooking.Text = "Ngày chiếu";
            // 
            // dtpDateBooking
            // 
            this.dtpDateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateBooking.Location = new System.Drawing.Point(33, 207);
            this.dtpDateBooking.Name = "dtpDateBooking";
            this.dtpDateBooking.Size = new System.Drawing.Size(350, 38);
            this.dtpDateBooking.TabIndex = 15;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Red;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(223, 491);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(160, 60);
            this.btnBooking.TabIndex = 9;
            this.btnBooking.Text = "Đặt vé";
            this.btnBooking.UseVisualStyleBackColor = false;
            // 
            // cbMovieBooking
            // 
            this.cbMovieBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovieBooking.FormattingEnabled = true;
            this.cbMovieBooking.Location = new System.Drawing.Point(33, 307);
            this.cbMovieBooking.Name = "cbMovieBooking";
            this.cbMovieBooking.Size = new System.Drawing.Size(350, 39);
            this.cbMovieBooking.TabIndex = 14;
            // 
            // cbTimeBooking
            // 
            this.cbTimeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeBooking.FormattingEnabled = true;
            this.cbTimeBooking.Location = new System.Drawing.Point(33, 408);
            this.cbTimeBooking.Name = "cbTimeBooking";
            this.cbTimeBooking.Size = new System.Drawing.Size(350, 39);
            this.cbTimeBooking.TabIndex = 10;
            // 
            // lbFilmBooking
            // 
            this.lbFilmBooking.AutoSize = true;
            this.lbFilmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFilmBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmBooking.ForeColor = System.Drawing.Color.White;
            this.lbFilmBooking.Location = new System.Drawing.Point(33, 250);
            this.lbFilmBooking.Name = "lbFilmBooking";
            this.lbFilmBooking.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbFilmBooking.Size = new System.Drawing.Size(80, 52);
            this.lbFilmBooking.TabIndex = 13;
            this.lbFilmBooking.Text = "Phim";
            // 
            // lbTimeBooking
            // 
            this.lbTimeBooking.AutoSize = true;
            this.lbTimeBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeBooking.ForeColor = System.Drawing.Color.White;
            this.lbTimeBooking.Location = new System.Drawing.Point(33, 351);
            this.lbTimeBooking.Name = "lbTimeBooking";
            this.lbTimeBooking.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbTimeBooking.Size = new System.Drawing.Size(150, 52);
            this.lbTimeBooking.TabIndex = 11;
            this.lbTimeBooking.Text = "Suất chiếu";
            // 
            // flpSeat
            // 
            this.flpSeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpSeat.Location = new System.Drawing.Point(950, 0);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(632, 484);
            this.flpSeat.TabIndex = 2;
            // 
            // panelTheater
            // 
            this.panelTheater.Controls.Add(this.lbTheaterName);
            this.panelTheater.Controls.Add(this.lbScreenName);
            this.panelTheater.Controls.Add(this.cbScreen);
            this.panelTheater.Controls.Add(this.cbTheater);
            this.panelTheater.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTheater.Location = new System.Drawing.Point(950, 484);
            this.panelTheater.Name = "panelTheater";
            this.panelTheater.Size = new System.Drawing.Size(632, 146);
            this.panelTheater.TabIndex = 3;
            // 
            // lbTheaterName
            // 
            this.lbTheaterName.AutoSize = true;
            this.lbTheaterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterName.ForeColor = System.Drawing.Color.White;
            this.lbTheaterName.Location = new System.Drawing.Point(6, 6);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbTheaterName.Size = new System.Drawing.Size(123, 52);
            this.lbTheaterName.TabIndex = 19;
            this.lbTheaterName.Text = "Tên Rạp";
            // 
            // lbScreenName
            // 
            this.lbScreenName.AutoSize = true;
            this.lbScreenName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScreenName.ForeColor = System.Drawing.Color.White;
            this.lbScreenName.Location = new System.Drawing.Point(6, 75);
            this.lbScreenName.Name = "lbScreenName";
            this.lbScreenName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbScreenName.Size = new System.Drawing.Size(236, 52);
            this.lbScreenName.TabIndex = 18;
            this.lbScreenName.Text = "Tên Phòng Chiếu";
            // 
            // cbScreen
            // 
            this.cbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Location = new System.Drawing.Point(248, 88);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(372, 39);
            this.cbScreen.TabIndex = 17;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(248, 19);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(372, 39);
            this.cbTheater.TabIndex = 16;
            this.cbTheater.SelectedIndexChanged += new System.EventHandler(this.cbTheater_SelectedIndexChanged);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.panelTheater);
            this.Controls.Add(this.flpSeat);
            this.Controls.Add(this.panelBooking);
            this.Name = "frmBooking";
            this.Text = "Đặt vé";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.panelBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTheater.ResumeLayout(false);
            this.panelTheater.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.DateTimePicker dtpDateBooking;
        private System.Windows.Forms.ComboBox cbMovieBooking;
        private System.Windows.Forms.Label lbFilmBooking;
        private System.Windows.Forms.Label lbDateBooking;
        private System.Windows.Forms.Label lbTimeBooking;
        private System.Windows.Forms.ComboBox cbTimeBooking;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTheater;
        private System.Windows.Forms.ComboBox cbTheater;
        private System.Windows.Forms.Label lbTheaterName;
        private System.Windows.Forms.Label lbScreenName;
        private System.Windows.Forms.ComboBox cbScreen;
        private System.Windows.Forms.PictureBox pbPoster;
    }
}