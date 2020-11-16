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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.dtpShowtime = new System.Windows.Forms.DateTimePicker();
            this.lbShowtime = new System.Windows.Forms.Label();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(598, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbMovie
            // 
            this.cbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(891, 201);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(389, 39);
            this.cbMovie.TabIndex = 1;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbMovieName.ForeColor = System.Drawing.Color.White;
            this.lbMovieName.Location = new System.Drawing.Point(658, 204);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(133, 32);
            this.lbMovieName.TabIndex = 2;
            this.lbMovieName.Text = "Tên phim";
            // 
            // dtpShowtime
            // 
            this.dtpShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpShowtime.Location = new System.Drawing.Point(891, 274);
            this.dtpShowtime.Name = "dtpShowtime";
            this.dtpShowtime.Size = new System.Drawing.Size(389, 38);
            this.dtpShowtime.TabIndex = 3;
            // 
            // lbShowtime
            // 
            this.lbShowtime.AutoSize = true;
            this.lbShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbShowtime.ForeColor = System.Drawing.Color.White;
            this.lbShowtime.Location = new System.Drawing.Point(658, 280);
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
            this.lbTheaterName.Location = new System.Drawing.Point(658, 58);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Size = new System.Drawing.Size(143, 32);
            this.lbTheaterName.TabIndex = 6;
            this.lbTheaterName.Text = "Rạp chiếu";
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(891, 55);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(389, 39);
            this.cbTheater.TabIndex = 5;
            // 
            // lbScreenName
            // 
            this.lbScreenName.AutoSize = true;
            this.lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreenName.ForeColor = System.Drawing.Color.White;
            this.lbScreenName.Location = new System.Drawing.Point(658, 131);
            this.lbScreenName.Name = "lbScreenName";
            this.lbScreenName.Size = new System.Drawing.Size(227, 32);
            this.lbScreenName.TabIndex = 8;
            this.lbScreenName.Text = "Tên phòng chiếu";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(891, 128);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(389, 39);
            this.comboBox3.TabIndex = 7;
            // 
            // frmShowtimeManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1582, 623);
            this.Controls.Add(this.lbScreenName);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.lbTheaterName);
            this.Controls.Add(this.cbTheater);
            this.Controls.Add(this.lbShowtime);
            this.Controls.Add(this.dtpShowtime);
            this.Controls.Add(this.lbMovieName);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmShowtimeManaging";
            this.Text = "frmShowtimeManaging";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.DateTimePicker dtpShowtime;
        private System.Windows.Forms.Label lbShowtime;
        private System.Windows.Forms.Label lbTheaterName;
        private System.Windows.Forms.ComboBox cbTheater;
        private System.Windows.Forms.Label lbScreenName;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}