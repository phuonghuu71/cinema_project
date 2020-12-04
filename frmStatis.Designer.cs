namespace CSMS
{
    partial class frmStatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatis));
            this.tc = new MaterialSkin.Controls.MaterialTabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.dtgvStatis = new System.Windows.Forms.DataGridView();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnStatis = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ms = new MaterialSkin.Controls.MaterialTabSelector();
            this.report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tc.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatis)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tp1);
            this.tc.Controls.Add(this.tp2);
            this.tc.Depth = 0;
            this.tc.Location = new System.Drawing.Point(0, 45);
            this.tc.MouseState = MaterialSkin.MouseState.HOVER;
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(1362, 708);
            this.tc.TabIndex = 0;
            // 
            // tp1
            // 
            this.tp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.tp1.Controls.Add(this.dtpFrom);
            this.tp1.Controls.Add(this.dtpTo);
            this.tp1.Controls.Add(this.btnStatis);
            this.tp1.Controls.Add(this.dtgvStatis);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(1354, 679);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Thống kê";
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.report);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(1354, 679);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Report";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // dtgvStatis
            // 
            this.dtgvStatis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvStatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatis.Location = new System.Drawing.Point(8, 74);
            this.dtgvStatis.Name = "dtgvStatis";
            this.dtgvStatis.RowHeadersWidth = 51;
            this.dtgvStatis.RowTemplate.Height = 24;
            this.dtgvStatis.Size = new System.Drawing.Size(1338, 597);
            this.dtgvStatis.TabIndex = 34;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(8, 6);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(449, 38);
            this.dtpFrom.TabIndex = 35;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.dtpTo.Location = new System.Drawing.Point(897, 6);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(449, 38);
            this.dtpTo.TabIndex = 36;
            // 
            // btnStatis
            // 
            this.btnStatis.ActiveBorderThickness = 1;
            this.btnStatis.ActiveCornerRadius = 15;
            this.btnStatis.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStatis.ActiveForecolor = System.Drawing.Color.White;
            this.btnStatis.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnStatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnStatis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatis.BackgroundImage")));
            this.btnStatis.ButtonText = "THỐNG KÊ";
            this.btnStatis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatis.ForeColor = System.Drawing.Color.White;
            this.btnStatis.IdleBorderThickness = 1;
            this.btnStatis.IdleCornerRadius = 15;
            this.btnStatis.IdleFillColor = System.Drawing.Color.Red;
            this.btnStatis.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnStatis.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnStatis.Location = new System.Drawing.Point(570, 6);
            this.btnStatis.Margin = new System.Windows.Forms.Padding(5);
            this.btnStatis.Name = "btnStatis";
            this.btnStatis.Size = new System.Drawing.Size(214, 60);
            this.btnStatis.TabIndex = 37;
            this.btnStatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStatis.Click += new System.EventHandler(this.btnStatis_Click);
            // 
            // ms
            // 
            this.ms.BaseTabControl = this.tc;
            this.ms.Depth = 0;
            this.ms.Dock = System.Windows.Forms.DockStyle.Top;
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.MouseState = MaterialSkin.MouseState.HOVER;
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1362, 30);
            this.ms.TabIndex = 1;
            this.ms.Text = "materialTabSelector1";
            // 
            // report
            // 
            this.report.ActiveViewIndex = -1;
            this.report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report.Cursor = System.Windows.Forms.Cursors.Default;
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report.Location = new System.Drawing.Point(3, 3);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(1348, 673);
            this.report.TabIndex = 0;
            // 
            // frmStatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.tc);
            this.Name = "frmStatis";
            this.Text = "frmStatis";
            this.Load += new System.EventHandler(this.frmStatis_Load);
            this.tc.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tc;
        private System.Windows.Forms.TabPage tp1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStatis;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridView dtgvStatis;
        private System.Windows.Forms.TabPage tp2;
        private MaterialSkin.Controls.MaterialTabSelector ms;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer report;
    }
}