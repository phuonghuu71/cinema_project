namespace CSMS
{
    partial class frmChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePwd));
            this.panelChangePwd = new System.Windows.Forms.Panel();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOldPwd = new System.Windows.Forms.Label();
            this.btnChangePwd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelChangePwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChangePwd
            // 
            this.panelChangePwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelChangePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panelChangePwd.Controls.Add(this.btnChangePwd);
            this.panelChangePwd.Controls.Add(this.imgLogo);
            this.panelChangePwd.Controls.Add(this.txtNewPwd);
            this.panelChangePwd.Controls.Add(this.txtOldPwd);
            this.panelChangePwd.Controls.Add(this.label1);
            this.panelChangePwd.Controls.Add(this.lbOldPwd);
            this.panelChangePwd.Location = new System.Drawing.Point(483, 130);
            this.panelChangePwd.Name = "panelChangePwd";
            this.panelChangePwd.Size = new System.Drawing.Size(396, 493);
            this.panelChangePwd.TabIndex = 0;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwd.Location = new System.Drawing.Point(73, 337);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(250, 38);
            this.txtNewPwd.TabIndex = 3;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPwd.Location = new System.Drawing.Point(73, 216);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(250, 38);
            this.txtOldPwd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu mới";
            // 
            // lbOldPwd
            // 
            this.lbOldPwd.AutoSize = true;
            this.lbOldPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPwd.ForeColor = System.Drawing.Color.White;
            this.lbOldPwd.Location = new System.Drawing.Point(73, 155);
            this.lbOldPwd.Name = "lbOldPwd";
            this.lbOldPwd.Size = new System.Drawing.Size(195, 38);
            this.lbOldPwd.TabIndex = 0;
            this.lbOldPwd.Text = "Mật khẩu cũ";
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.ActiveBorderThickness = 1;
            this.btnChangePwd.ActiveCornerRadius = 15;
            this.btnChangePwd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnChangePwd.ActiveForecolor = System.Drawing.Color.White;
            this.btnChangePwd.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnChangePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnChangePwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangePwd.BackgroundImage")));
            this.btnChangePwd.ButtonText = "ĐỔI MẬT KHẨU";
            this.btnChangePwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePwd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePwd.ForeColor = System.Drawing.Color.White;
            this.btnChangePwd.IdleBorderThickness = 1;
            this.btnChangePwd.IdleCornerRadius = 15;
            this.btnChangePwd.IdleFillColor = System.Drawing.Color.Red;
            this.btnChangePwd.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnChangePwd.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnChangePwd.Location = new System.Drawing.Point(162, 402);
            this.btnChangePwd.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(161, 60);
            this.btnChangePwd.TabIndex = 31;
            this.btnChangePwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Image = global::CSMS.Properties.Resources._1280px_UNO_Logo_svg;
            this.imgLogo.Location = new System.Drawing.Point(80, 30);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.panelChangePwd;
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.panelChangePwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmChangePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmChangePwd_Load);
            this.panelChangePwd.ResumeLayout(false);
            this.panelChangePwd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChangePwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbOldPwd;
        private System.Windows.Forms.PictureBox imgLogo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChangePwd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}