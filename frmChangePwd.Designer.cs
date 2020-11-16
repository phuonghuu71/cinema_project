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
            this.panelChangePwd = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnChangePwd = new System.Windows.Forms.Button();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbOldPwd = new System.Windows.Forms.Label();
            this.panelChangePwd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChangePwd
            // 
            this.panelChangePwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelChangePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panelChangePwd.Controls.Add(this.imgLogo);
            this.panelChangePwd.Controls.Add(this.btnChangePwd);
            this.panelChangePwd.Controls.Add(this.txtNewPwd);
            this.panelChangePwd.Controls.Add(this.txtOldPwd);
            this.panelChangePwd.Controls.Add(this.label1);
            this.panelChangePwd.Controls.Add(this.lbOldPwd);
            this.panelChangePwd.Location = new System.Drawing.Point(250, 0);
            this.panelChangePwd.Name = "panelChangePwd";
            this.panelChangePwd.Size = new System.Drawing.Size(396, 493);
            this.panelChangePwd.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgLogo.Image = global::CSMS.Properties.Resources._1280px_UNO_Logo_svg;
            this.imgLogo.Location = new System.Drawing.Point(93, 26);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 100);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.BackColor = System.Drawing.Color.Red;
            this.btnChangePwd.FlatAppearance.BorderSize = 0;
            this.btnChangePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePwd.ForeColor = System.Drawing.Color.Transparent;
            this.btnChangePwd.Location = new System.Drawing.Point(141, 371);
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(190, 50);
            this.btnChangePwd.TabIndex = 4;
            this.btnChangePwd.Text = "Đổi mật khẩu";
            this.btnChangePwd.UseVisualStyleBackColor = false;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwd.Location = new System.Drawing.Point(81, 311);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(250, 38);
            this.txtNewPwd.TabIndex = 3;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPwd.Location = new System.Drawing.Point(81, 190);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Size = new System.Drawing.Size(250, 38);
            this.txtOldPwd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 250);
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
            this.lbOldPwd.Location = new System.Drawing.Point(81, 129);
            this.lbOldPwd.Name = "lbOldPwd";
            this.lbOldPwd.Size = new System.Drawing.Size(195, 38);
            this.lbOldPwd.TabIndex = 0;
            this.lbOldPwd.Text = "Mật khẩu cũ";
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panelChangePwd);
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
        private System.Windows.Forms.Button btnChangePwd;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}