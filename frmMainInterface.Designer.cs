namespace CSMS
{
    partial class frmMainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainInterface));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelStaffInfo = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.beMaininterface = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnMovieList = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.btnStaffInfo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnServiceManaging = new System.Windows.Forms.Button();
            this.btnShowtimeManaging = new System.Windows.Forms.Button();
            this.btnScreenManaging = new System.Windows.Forms.Button();
            this.btnTheaterManaging = new System.Windows.Forms.Button();
            this.btnMovieManager = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelStaffInfo.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.panelMenu.Controls.Add(this.btnMovieList);
            this.panelMenu.Controls.Add(this.btnBooking);
            this.panelMenu.Controls.Add(this.panelStaffInfo);
            this.panelMenu.Controls.Add(this.btnStaffInfo);
            this.panelMenu.Controls.Add(this.panelAdmin);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 900);
            this.panelMenu.TabIndex = 0;
            // 
            // panelStaffInfo
            // 
            this.panelStaffInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(6)))), ((int)(((byte)(59)))));
            this.panelStaffInfo.Controls.Add(this.btnChangePwd);
            this.panelStaffInfo.Controls.Add(this.btnPersonalInfo);
            this.panelStaffInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffInfo.Location = new System.Drawing.Point(0, 580);
            this.panelStaffInfo.Name = "panelStaffInfo";
            this.panelStaffInfo.Size = new System.Drawing.Size(220, 120);
            this.panelStaffInfo.TabIndex = 4;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(6)))), ((int)(((byte)(59)))));
            this.panelAdmin.Controls.Add(this.button3);
            this.panelAdmin.Controls.Add(this.button2);
            this.panelAdmin.Controls.Add(this.btnServiceManaging);
            this.panelAdmin.Controls.Add(this.btnShowtimeManaging);
            this.panelAdmin.Controls.Add(this.btnScreenManaging);
            this.panelAdmin.Controls.Add(this.btnTheaterManaging);
            this.panelAdmin.Controls.Add(this.btnMovieManager);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdmin.Location = new System.Drawing.Point(0, 160);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(220, 360);
            this.panelAdmin.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.imgLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(220, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1380, 100);
            this.panelTop.TabIndex = 2;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(220, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1380, 800);
            this.panelChildForm.TabIndex = 3;
            // 
            // beMaininterface
            // 
            this.beMaininterface.ElipseRadius = 15;
            this.beMaininterface.TargetControl = this;
            // 
            // btnMovieList
            // 
            this.btnMovieList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovieList.FlatAppearance.BorderSize = 0;
            this.btnMovieList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMovieList.Image = global::CSMS.Properties.Resources.theater_masks_solid;
            this.btnMovieList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovieList.Location = new System.Drawing.Point(0, 760);
            this.btnMovieList.Name = "btnMovieList";
            this.btnMovieList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMovieList.Size = new System.Drawing.Size(220, 60);
            this.btnMovieList.TabIndex = 9;
            this.btnMovieList.Text = "  Danh sách phim";
            this.btnMovieList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovieList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovieList.UseVisualStyleBackColor = true;
            this.btnMovieList.Click += new System.EventHandler(this.btnMovieList_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBooking.Image = global::CSMS.Properties.Resources.ticket_alt_solid_4Fj_icon;
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(0, 700);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBooking.Size = new System.Drawing.Size(220, 60);
            this.btnBooking.TabIndex = 5;
            this.btnBooking.Text = "  Đặt vé";
            this.btnBooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePwd.FlatAppearance.BorderSize = 0;
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePwd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChangePwd.Image = global::CSMS.Properties.Resources.key_solid_1_;
            this.btnChangePwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePwd.Location = new System.Drawing.Point(0, 50);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Padding = new System.Windows.Forms.Padding(25, 5, 0, 5);
            this.btnChangePwd.Size = new System.Drawing.Size(220, 50);
            this.btnChangePwd.TabIndex = 1;
            this.btnChangePwd.Text = "  Đổi mật khẩu";
            this.btnChangePwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePwd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePwd.UseVisualStyleBackColor = true;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonalInfo.FlatAppearance.BorderSize = 0;
            this.btnPersonalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonalInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPersonalInfo.Image = global::CSMS.Properties.Resources.info_circle_solid;
            this.btnPersonalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalInfo.Location = new System.Drawing.Point(0, 0);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.btnPersonalInfo.Size = new System.Drawing.Size(220, 50);
            this.btnPersonalInfo.TabIndex = 0;
            this.btnPersonalInfo.Text = "  Thông tin cá nhân";
            this.btnPersonalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPersonalInfo.UseVisualStyleBackColor = true;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // btnStaffInfo
            // 
            this.btnStaffInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffInfo.FlatAppearance.BorderSize = 0;
            this.btnStaffInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStaffInfo.Image = global::CSMS.Properties.Resources.user_alt_solid;
            this.btnStaffInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffInfo.Location = new System.Drawing.Point(0, 520);
            this.btnStaffInfo.Name = "btnStaffInfo";
            this.btnStaffInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaffInfo.Size = new System.Drawing.Size(220, 60);
            this.btnStaffInfo.TabIndex = 2;
            this.btnStaffInfo.Text = "  Nhân viên";
            this.btnStaffInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffInfo.UseVisualStyleBackColor = true;
            this.btnStaffInfo.Click += new System.EventHandler(this.btnStaffInfo_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::CSMS.Properties.Resources.film_solid2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 300);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.button3.Size = new System.Drawing.Size(220, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "  Report";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::CSMS.Properties.Resources.film_solid2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 250);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.button2.Size = new System.Drawing.Size(220, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "  Thống kê doanh thu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnServiceManaging
            // 
            this.btnServiceManaging.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceManaging.FlatAppearance.BorderSize = 0;
            this.btnServiceManaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceManaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceManaging.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServiceManaging.Image = global::CSMS.Properties.Resources.film_solid2;
            this.btnServiceManaging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceManaging.Location = new System.Drawing.Point(0, 200);
            this.btnServiceManaging.Name = "btnServiceManaging";
            this.btnServiceManaging.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.btnServiceManaging.Size = new System.Drawing.Size(220, 50);
            this.btnServiceManaging.TabIndex = 4;
            this.btnServiceManaging.Text = "  Quản lý dịch vụ";
            this.btnServiceManaging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceManaging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServiceManaging.UseVisualStyleBackColor = true;
            this.btnServiceManaging.Click += new System.EventHandler(this.btnServiceManaging_Click);
            // 
            // btnShowtimeManaging
            // 
            this.btnShowtimeManaging.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowtimeManaging.FlatAppearance.BorderSize = 0;
            this.btnShowtimeManaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowtimeManaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowtimeManaging.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowtimeManaging.Image = global::CSMS.Properties.Resources.film_solid2;
            this.btnShowtimeManaging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowtimeManaging.Location = new System.Drawing.Point(0, 150);
            this.btnShowtimeManaging.Name = "btnShowtimeManaging";
            this.btnShowtimeManaging.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.btnShowtimeManaging.Size = new System.Drawing.Size(220, 50);
            this.btnShowtimeManaging.TabIndex = 3;
            this.btnShowtimeManaging.Text = "  Quản lý lịch chiếu";
            this.btnShowtimeManaging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowtimeManaging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowtimeManaging.UseVisualStyleBackColor = true;
            this.btnShowtimeManaging.Click += new System.EventHandler(this.btnShowtimeManaging_Click);
            // 
            // btnScreenManaging
            // 
            this.btnScreenManaging.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreenManaging.FlatAppearance.BorderSize = 0;
            this.btnScreenManaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenManaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenManaging.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnScreenManaging.Image = global::CSMS.Properties.Resources.film_solid2;
            this.btnScreenManaging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenManaging.Location = new System.Drawing.Point(0, 100);
            this.btnScreenManaging.Name = "btnScreenManaging";
            this.btnScreenManaging.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.btnScreenManaging.Size = new System.Drawing.Size(220, 50);
            this.btnScreenManaging.TabIndex = 1;
            this.btnScreenManaging.Text = "  Quản lý phòng chiếu";
            this.btnScreenManaging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenManaging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScreenManaging.UseVisualStyleBackColor = true;
            this.btnScreenManaging.Click += new System.EventHandler(this.btnScreenManaging_Click);
            // 
            // btnTheaterManaging
            // 
            this.btnTheaterManaging.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheaterManaging.FlatAppearance.BorderSize = 0;
            this.btnTheaterManaging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheaterManaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheaterManaging.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTheaterManaging.Image = global::CSMS.Properties.Resources.film_solid2;
            this.btnTheaterManaging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheaterManaging.Location = new System.Drawing.Point(0, 50);
            this.btnTheaterManaging.Name = "btnTheaterManaging";
            this.btnTheaterManaging.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.btnTheaterManaging.Size = new System.Drawing.Size(220, 50);
            this.btnTheaterManaging.TabIndex = 2;
            this.btnTheaterManaging.Text = "  Quản lý rạp chiếu";
            this.btnTheaterManaging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheaterManaging.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheaterManaging.UseVisualStyleBackColor = true;
            this.btnTheaterManaging.Click += new System.EventHandler(this.btnTheaterManaging_Click);
            // 
            // btnMovieManager
            // 
            this.btnMovieManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovieManager.FlatAppearance.BorderSize = 0;
            this.btnMovieManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMovieManager.Image = global::CSMS.Properties.Resources.film_solid2;
            this.btnMovieManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovieManager.Location = new System.Drawing.Point(0, 0);
            this.btnMovieManager.Name = "btnMovieManager";
            this.btnMovieManager.Padding = new System.Windows.Forms.Padding(25, 5, 0, 10);
            this.btnMovieManager.Size = new System.Drawing.Size(220, 50);
            this.btnMovieManager.TabIndex = 0;
            this.btnMovieManager.Text = "  Quản lý phim";
            this.btnMovieManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovieManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovieManager.UseVisualStyleBackColor = true;
            this.btnMovieManager.Click += new System.EventHandler(this.btnMovieManager_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = global::CSMS.Properties.Resources.sign_out_alt_solid;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 840);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "  Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.Image = global::CSMS.Properties.Resources.desktop_solid;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 100);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(220, 60);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "  Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::CSMS.Properties.Resources._1280px_UNO_Logo_svg;
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 73);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // frmMainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý rạp phim";
            this.panelMenu.ResumeLayout(false);
            this.panelStaffInfo.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnStaffInfo;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelStaffInfo;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnMovieManager;
        private System.Windows.Forms.Button btnMovieList;
        private System.Windows.Forms.Button btnScreenManaging;
        private System.Windows.Forms.Button btnTheaterManaging;
        private System.Windows.Forms.Button btnShowtimeManaging;
        private Bunifu.Framework.UI.BunifuElipse beMaininterface;
        private System.Windows.Forms.Button btnServiceManaging;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

