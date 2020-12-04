namespace CSMS
{
    partial class frmStaffInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbGender = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbAge = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbCMND = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tbGender);
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.tbAge);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.tbCMND);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.tbPhone);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(210, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 741);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 15;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "CẬP NHẬT";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 15;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.Red;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(739, 659);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 60);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbGender
            // 
            this.tbGender.BorderColorFocused = System.Drawing.Color.Red;
            this.tbGender.BorderColorIdle = System.Drawing.Color.White;
            this.tbGender.BorderColorMouseHover = System.Drawing.Color.Red;
            this.tbGender.BorderThickness = 3;
            this.tbGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbGender.ForeColor = System.Drawing.Color.White;
            this.tbGender.isPassword = false;
            this.tbGender.Location = new System.Drawing.Point(307, 580);
            this.tbGender.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(592, 65);
            this.tbGender.TabIndex = 12;
            this.tbGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Image = global::CSMS.Properties.Resources._1280px_UNO_Logo_svg;
            this.imgLogo.Location = new System.Drawing.Point(371, 15);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 2;
            this.imgLogo.TabStop = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(53, 613);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(130, 32);
            this.bunifuCustomLabel6.TabIndex = 11;
            this.bunifuCustomLabel6.Text = "Giới Tính";
            // 
            // tbAge
            // 
            this.tbAge.BorderColorFocused = System.Drawing.Color.Red;
            this.tbAge.BorderColorIdle = System.Drawing.Color.White;
            this.tbAge.BorderColorMouseHover = System.Drawing.Color.Red;
            this.tbAge.BorderThickness = 3;
            this.tbAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbAge.ForeColor = System.Drawing.Color.White;
            this.tbAge.isPassword = false;
            this.tbAge.Location = new System.Drawing.Point(307, 492);
            this.tbAge.Margin = new System.Windows.Forms.Padding(6);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(592, 65);
            this.tbAge.TabIndex = 10;
            this.tbAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(53, 525);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(71, 32);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Tuổi";
            // 
            // tbCMND
            // 
            this.tbCMND.BorderColorFocused = System.Drawing.Color.Red;
            this.tbCMND.BorderColorIdle = System.Drawing.Color.White;
            this.tbCMND.BorderColorMouseHover = System.Drawing.Color.Red;
            this.tbCMND.BorderThickness = 3;
            this.tbCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbCMND.ForeColor = System.Drawing.Color.White;
            this.tbCMND.isPassword = false;
            this.tbCMND.Location = new System.Drawing.Point(307, 404);
            this.tbCMND.Margin = new System.Windows.Forms.Padding(6);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(592, 65);
            this.tbCMND.TabIndex = 8;
            this.tbCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(53, 437);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(98, 32);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "CMND";
            // 
            // tbAddress
            // 
            this.tbAddress.BorderColorFocused = System.Drawing.Color.Red;
            this.tbAddress.BorderColorIdle = System.Drawing.Color.White;
            this.tbAddress.BorderColorMouseHover = System.Drawing.Color.Red;
            this.tbAddress.BorderThickness = 3;
            this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbAddress.ForeColor = System.Drawing.Color.White;
            this.tbAddress.isPassword = false;
            this.tbAddress.Location = new System.Drawing.Point(307, 316);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(592, 65);
            this.tbAddress.TabIndex = 6;
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(53, 349);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(108, 32);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Địa Chỉ";
            // 
            // tbPhone
            // 
            this.tbPhone.BorderColorFocused = System.Drawing.Color.Red;
            this.tbPhone.BorderColorIdle = System.Drawing.Color.White;
            this.tbPhone.BorderColorMouseHover = System.Drawing.Color.Red;
            this.tbPhone.BorderThickness = 3;
            this.tbPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbPhone.ForeColor = System.Drawing.Color.White;
            this.tbPhone.isPassword = false;
            this.tbPhone.Location = new System.Drawing.Point(307, 228);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(6);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(592, 65);
            this.tbPhone.TabIndex = 4;
            this.tbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(53, 261);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(195, 32);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Số Điện Thoại";
            // 
            // tbName
            // 
            this.tbName.BorderColorFocused = System.Drawing.Color.Red;
            this.tbName.BorderColorIdle = System.Drawing.Color.White;
            this.tbName.BorderColorMouseHover = System.Drawing.Color.Red;
            this.tbName.BorderThickness = 3;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.isPassword = false;
            this.tbName.Location = new System.Drawing.Point(307, 140);
            this.tbName.Margin = new System.Windows.Forms.Padding(6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(592, 65);
            this.tbName.TabIndex = 2;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(53, 173);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 32);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Họ Tên";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.panel1;
            // 
            // frmStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmStaffInfo";
            this.Text = "frmStaffInfo";
            this.Load += new System.EventHandler(this.frmStaffInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbAge;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCMND;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbPhone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbName;
        private System.Windows.Forms.PictureBox imgLogo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbGender;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
    }
}