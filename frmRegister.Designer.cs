namespace CSMS
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnReturn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtReEnterPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.beRegister = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbLogo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReturn, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtReEnterPassword, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 650);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HintForeColor = System.Drawing.Color.White;
            this.txtUsername.HintText = "Tên đăng nhập";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Red;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Red;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(56, 216);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(368, 37);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRegister
            // 
            this.btnRegister.ActiveBorderThickness = 1;
            this.btnRegister.ActiveCornerRadius = 20;
            this.btnRegister.ActiveFillColor = System.Drawing.Color.Brown;
            this.btnRegister.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegister.ActiveLineColor = System.Drawing.Color.Brown;
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.ButtonText = "ĐĂNG KÝ";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.IdleBorderThickness = 1;
            this.btnRegister.IdleCornerRadius = 20;
            this.btnRegister.IdleFillColor = System.Drawing.Color.Red;
            this.btnRegister.IdleForecolor = System.Drawing.Color.White;
            this.btnRegister.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnRegister.Location = new System.Drawing.Point(57, 420);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(366, 60);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HintForeColor = System.Drawing.Color.White;
            this.txtPassword.HintText = "Mật khẩu";
            this.txtPassword.isPassword = false;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Red;
            this.txtPassword.LineIdleColor = System.Drawing.Color.Red;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(56, 286);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(368, 37);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtPassword_OnValueChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbLogo.Image = global::CSMS.Properties.Resources._1280px_UNO_Logo_svg;
            this.pbLogo.Location = new System.Drawing.Point(162, 47);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(156, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(84, 164);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(311, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "RẠP CHIẾU PHIM UNO";
            // 
            // btnReturn
            // 
            this.btnReturn.ActiveBorderThickness = 1;
            this.btnReturn.ActiveCornerRadius = 20;
            this.btnReturn.ActiveFillColor = System.Drawing.Color.Brown;
            this.btnReturn.ActiveForecolor = System.Drawing.Color.White;
            this.btnReturn.ActiveLineColor = System.Drawing.Color.Brown;
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.ButtonText = "QUAY LẠI";
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IdleBorderThickness = 1;
            this.btnReturn.IdleCornerRadius = 20;
            this.btnReturn.IdleFillColor = System.Drawing.Color.Red;
            this.btnReturn.IdleForecolor = System.Drawing.Color.White;
            this.btnReturn.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnReturn.Location = new System.Drawing.Point(140, 557);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 60);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReEnterPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtReEnterPassword.ForeColor = System.Drawing.Color.White;
            this.txtReEnterPassword.HintForeColor = System.Drawing.Color.White;
            this.txtReEnterPassword.HintText = "Nhập lại mật khẩu";
            this.txtReEnterPassword.isPassword = false;
            this.txtReEnterPassword.LineFocusedColor = System.Drawing.Color.Red;
            this.txtReEnterPassword.LineIdleColor = System.Drawing.Color.Red;
            this.txtReEnterPassword.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtReEnterPassword.LineThickness = 4;
            this.txtReEnterPassword.Location = new System.Drawing.Point(56, 356);
            this.txtReEnterPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.Size = new System.Drawing.Size(368, 37);
            this.txtReEnterPassword.TabIndex = 9;
            this.txtReEnterPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReEnterPassword.OnValueChanged += new System.EventHandler(this.txtReEnterPassword_OnValueChanged);
            // 
            // beRegister
            // 
            this.beRegister.ElipseRadius = 15;
            this.beRegister.TargetControl = this;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReturn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtReEnterPassword;
        private Bunifu.Framework.UI.BunifuElipse beRegister;
    }
}