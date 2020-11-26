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
            this.panelServices = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.colMovie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colShowtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeatName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnServiceAdd = new System.Windows.Forms.Button();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.lbService = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.testbox = new System.Windows.Forms.TextBox();
            this.btnInsertSeat = new System.Windows.Forms.Button();
            this.cbMovieBooking = new System.Windows.Forms.ComboBox();
            this.cbTimeBooking = new System.Windows.Forms.ComboBox();
            this.lbFilmBooking = new System.Windows.Forms.Label();
            this.lbTimeBooking = new System.Windows.Forms.Label();
            this.tbPriceTotal = new System.Windows.Forms.TextBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTheater = new System.Windows.Forms.Panel();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panelflp = new System.Windows.Forms.Panel();
            this.colQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteSeat = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panelBooking.SuspendLayout();
            this.panelServices.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTheater.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelflp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBooking
            // 
            this.panelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panelBooking.Controls.Add(this.panelServices);
            this.panelBooking.Controls.Add(this.btnServiceAdd);
            this.panelBooking.Controls.Add(this.lbPrice);
            this.panelBooking.Controls.Add(this.tbPrice);
            this.panelBooking.Controls.Add(this.cbServices);
            this.panelBooking.Controls.Add(this.lbService);
            this.panelBooking.Controls.Add(this.panelLeft);
            this.panelBooking.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBooking.Location = new System.Drawing.Point(0, 0);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(619, 753);
            this.panelBooking.TabIndex = 1;
            // 
            // panelServices
            // 
            this.panelServices.Controls.Add(this.lvBill);
            this.panelServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelServices.Location = new System.Drawing.Point(0, 227);
            this.panelServices.Name = "panelServices";
            this.panelServices.Size = new System.Drawing.Size(619, 176);
            this.panelServices.TabIndex = 26;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMovie,
            this.colShowtime,
            this.colSeatName,
            this.colService,
            this.colQuantity,
            this.colTotal});
            this.lvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(0, 0);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(619, 176);
            this.lvBill.TabIndex = 19;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // colMovie
            // 
            this.colMovie.Text = "Tên phim";
            this.colMovie.Width = 176;
            // 
            // colShowtime
            // 
            this.colShowtime.Text = "Suất chiếu";
            this.colShowtime.Width = 153;
            // 
            // colSeatName
            // 
            this.colSeatName.Text = "Tên ghế";
            this.colSeatName.Width = 90;
            // 
            // colService
            // 
            this.colService.Text = "Dịch vụ";
            this.colService.Width = 78;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Thành tiền";
            this.colTotal.Width = 97;
            // 
            // btnServiceAdd
            // 
            this.btnServiceAdd.BackColor = System.Drawing.Color.Red;
            this.btnServiceAdd.FlatAppearance.BorderSize = 0;
            this.btnServiceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceAdd.ForeColor = System.Drawing.Color.White;
            this.btnServiceAdd.Location = new System.Drawing.Point(268, 155);
            this.btnServiceAdd.Name = "btnServiceAdd";
            this.btnServiceAdd.Size = new System.Drawing.Size(345, 60);
            this.btnServiceAdd.TabIndex = 18;
            this.btnServiceAdd.Text = "Thêm dịch vụ";
            this.btnServiceAdd.UseVisualStyleBackColor = false;
            this.btnServiceAdd.Click += new System.EventHandler(this.btnServiceAdd_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(33, 76);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbPrice.Size = new System.Drawing.Size(166, 52);
            this.lbPrice.TabIndex = 25;
            this.lbPrice.Text = "Giá Dịch Vụ";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbPrice.Location = new System.Drawing.Point(268, 90);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(345, 38);
            this.tbPrice.TabIndex = 24;
            // 
            // cbServices
            // 
            this.cbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(268, 12);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(345, 39);
            this.cbServices.TabIndex = 23;
            this.cbServices.SelectedIndexChanged += new System.EventHandler(this.cbServices_SelectedIndexChanged);
            // 
            // lbService
            // 
            this.lbService.AutoSize = true;
            this.lbService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbService.ForeColor = System.Drawing.Color.White;
            this.lbService.Location = new System.Drawing.Point(27, 13);
            this.lbService.Name = "lbService";
            this.lbService.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbService.Size = new System.Drawing.Size(170, 52);
            this.lbService.TabIndex = 22;
            this.lbService.Text = "Tên Dịch Vụ";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnDeleteSeat);
            this.panelLeft.Controls.Add(this.testbox);
            this.panelLeft.Controls.Add(this.btnInsertSeat);
            this.panelLeft.Controls.Add(this.cbMovieBooking);
            this.panelLeft.Controls.Add(this.cbTimeBooking);
            this.panelLeft.Controls.Add(this.lbFilmBooking);
            this.panelLeft.Controls.Add(this.lbTimeBooking);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLeft.Location = new System.Drawing.Point(0, 403);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(619, 350);
            this.panelLeft.TabIndex = 16;
            // 
            // testbox
            // 
            this.testbox.Location = new System.Drawing.Point(181, 22);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(181, 22);
            this.testbox.TabIndex = 17;
            // 
            // btnInsertSeat
            // 
            this.btnInsertSeat.BackColor = System.Drawing.Color.Red;
            this.btnInsertSeat.FlatAppearance.BorderSize = 0;
            this.btnInsertSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertSeat.ForeColor = System.Drawing.Color.White;
            this.btnInsertSeat.Location = new System.Drawing.Point(33, 268);
            this.btnInsertSeat.Name = "btnInsertSeat";
            this.btnInsertSeat.Size = new System.Drawing.Size(250, 60);
            this.btnInsertSeat.TabIndex = 16;
            this.btnInsertSeat.Text = "Thêm chỗ ngồi";
            this.btnInsertSeat.UseVisualStyleBackColor = false;
            this.btnInsertSeat.Click += new System.EventHandler(this.btnInsertSeat_Click);
            // 
            // cbMovieBooking
            // 
            this.cbMovieBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovieBooking.FormattingEnabled = true;
            this.cbMovieBooking.Location = new System.Drawing.Point(33, 69);
            this.cbMovieBooking.Name = "cbMovieBooking";
            this.cbMovieBooking.Size = new System.Drawing.Size(329, 39);
            this.cbMovieBooking.TabIndex = 14;
            this.cbMovieBooking.SelectedIndexChanged += new System.EventHandler(this.cbMovieBooking_SelectedIndexChanged);
            // 
            // cbTimeBooking
            // 
            this.cbTimeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeBooking.FormattingEnabled = true;
            this.cbTimeBooking.Location = new System.Drawing.Point(27, 185);
            this.cbTimeBooking.Name = "cbTimeBooking";
            this.cbTimeBooking.Size = new System.Drawing.Size(329, 39);
            this.cbTimeBooking.TabIndex = 10;
            this.cbTimeBooking.SelectedIndexChanged += new System.EventHandler(this.cbTimeBooking_SelectedIndexChanged);
            // 
            // lbFilmBooking
            // 
            this.lbFilmBooking.AutoSize = true;
            this.lbFilmBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFilmBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmBooking.ForeColor = System.Drawing.Color.White;
            this.lbFilmBooking.Location = new System.Drawing.Point(33, 12);
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
            this.lbTimeBooking.Location = new System.Drawing.Point(27, 128);
            this.lbTimeBooking.Name = "lbTimeBooking";
            this.lbTimeBooking.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbTimeBooking.Size = new System.Drawing.Size(150, 52);
            this.lbTimeBooking.TabIndex = 11;
            this.lbTimeBooking.Text = "Suất chiếu";
            // 
            // tbPriceTotal
            // 
            this.tbPriceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbPriceTotal.Location = new System.Drawing.Point(248, 92);
            this.tbPriceTotal.Name = "tbPriceTotal";
            this.tbPriceTotal.ReadOnly = true;
            this.tbPriceTotal.Size = new System.Drawing.Size(372, 38);
            this.tbPriceTotal.TabIndex = 16;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.Red;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(460, 136);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(160, 48);
            this.btnBooking.TabIndex = 9;
            this.btnBooking.Text = "Đặt vé";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // flpSeat
            // 
            this.flpSeat.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSeat.Location = new System.Drawing.Point(0, 0);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(731, 350);
            this.flpSeat.TabIndex = 2;
            // 
            // panelTheater
            // 
            this.panelTheater.Controls.Add(this.lbTheaterName);
            this.panelTheater.Controls.Add(this.lbScreenName);
            this.panelTheater.Controls.Add(this.cbScreen);
            this.panelTheater.Controls.Add(this.cbTheater);
            this.panelTheater.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTheater.Location = new System.Drawing.Point(619, 350);
            this.panelTheater.Name = "panelTheater";
            this.panelTheater.Size = new System.Drawing.Size(743, 186);
            this.panelTheater.TabIndex = 3;
            // 
            // lbTheaterName
            // 
            this.lbTheaterName.AutoSize = true;
            this.lbTheaterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterName.ForeColor = System.Drawing.Color.White;
            this.lbTheaterName.Location = new System.Drawing.Point(6, 20);
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
            this.lbScreenName.Location = new System.Drawing.Point(6, 80);
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
            this.cbScreen.Location = new System.Drawing.Point(248, 80);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(372, 39);
            this.cbScreen.TabIndex = 17;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(248, 20);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(372, 39);
            this.cbTheater.TabIndex = 16;
            this.cbTheater.SelectedIndexChanged += new System.EventHandler(this.cbTheater_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(134, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tổng tiền";
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.lbStatus);
            this.panelTotal.Controls.Add(this.tbStatus);
            this.panelTotal.Controls.Add(this.tbPriceTotal);
            this.panelTotal.Controls.Add(this.label1);
            this.panelTotal.Controls.Add(this.btnBooking);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotal.Location = new System.Drawing.Point(619, 536);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(743, 198);
            this.panelTotal.TabIndex = 18;
            // 
            // panelflp
            // 
            this.panelflp.Controls.Add(this.flpSeat);
            this.panelflp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelflp.Location = new System.Drawing.Point(619, 0);
            this.panelflp.Name = "panelflp";
            this.panelflp.Size = new System.Drawing.Size(743, 350);
            this.panelflp.TabIndex = 19;
            // 
            // colQuantity
            // 
            this.colQuantity.Text = "Số lượng";
            // 
            // btnDeleteSeat
            // 
            this.btnDeleteSeat.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSeat.FlatAppearance.BorderSize = 0;
            this.btnDeleteSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSeat.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSeat.Location = new System.Drawing.Point(328, 268);
            this.btnDeleteSeat.Name = "btnDeleteSeat";
            this.btnDeleteSeat.Size = new System.Drawing.Size(250, 60);
            this.btnDeleteSeat.TabIndex = 18;
            this.btnDeleteSeat.Text = "Xóa chỗ ngồi";
            this.btnDeleteSeat.UseVisualStyleBackColor = false;
            this.btnDeleteSeat.Click += new System.EventHandler(this.btnDeleteSeat_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbStatus.Location = new System.Drawing.Point(248, 27);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(372, 38);
            this.tbStatus.TabIndex = 18;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(6, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lbStatus.Size = new System.Drawing.Size(143, 52);
            this.lbStatus.TabIndex = 19;
            this.lbStatus.Text = "Tình trạng";
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelTheater);
            this.Controls.Add(this.panelflp);
            this.Controls.Add(this.panelBooking);
            this.Name = "frmBooking";
            this.Text = "Đặt vé";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
            this.panelServices.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelTheater.ResumeLayout(false);
            this.panelTheater.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panelflp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.ComboBox cbMovieBooking;
        private System.Windows.Forms.Label lbFilmBooking;
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
        private System.Windows.Forms.TextBox tbPriceTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertSeat;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.TextBox testbox;
        private System.Windows.Forms.Panel panelflp;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Button btnServiceAdd;
        private System.Windows.Forms.Panel panelServices;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader colMovie;
        private System.Windows.Forms.ColumnHeader colShowtime;
        private System.Windows.Forms.ColumnHeader colSeatName;
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colQuantity;
        private System.Windows.Forms.Button btnDeleteSeat;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbStatus;
    }
}