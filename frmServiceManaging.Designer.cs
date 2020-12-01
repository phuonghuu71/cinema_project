namespace CSMS
{
    partial class frmServiceManaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceManaging));
            this.mummyTextbox = new System.Windows.Forms.TextBox();
            this.lbServicePrice = new System.Windows.Forms.Label();
            this.lbServiceName = new System.Windows.Forms.Label();
            this.lbServiceId = new System.Windows.Forms.Label();
            this.dtgvService = new System.Windows.Forms.DataGridView();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbServiceId = new System.Windows.Forms.TextBox();
            this.tbServicePrice = new System.Windows.Forms.TextBox();
            this.tbServiceName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // mummyTextbox
            // 
            this.mummyTextbox.Location = new System.Drawing.Point(1307, 409);
            this.mummyTextbox.Name = "mummyTextbox";
            this.mummyTextbox.Size = new System.Drawing.Size(0, 22);
            this.mummyTextbox.TabIndex = 45;
            // 
            // lbServicePrice
            // 
            this.lbServicePrice.AutoSize = true;
            this.lbServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbServicePrice.ForeColor = System.Drawing.Color.White;
            this.lbServicePrice.Location = new System.Drawing.Point(794, 147);
            this.lbServicePrice.Name = "lbServicePrice";
            this.lbServicePrice.Size = new System.Drawing.Size(157, 32);
            this.lbServicePrice.TabIndex = 44;
            this.lbServicePrice.Text = "Giá dịch vụ";
            // 
            // lbServiceName
            // 
            this.lbServiceName.AutoSize = true;
            this.lbServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbServiceName.ForeColor = System.Drawing.Color.White;
            this.lbServiceName.Location = new System.Drawing.Point(794, 88);
            this.lbServiceName.Name = "lbServiceName";
            this.lbServiceName.Size = new System.Drawing.Size(161, 32);
            this.lbServiceName.TabIndex = 42;
            this.lbServiceName.Text = "Tên dịch vụ";
            // 
            // lbServiceId
            // 
            this.lbServiceId.AutoSize = true;
            this.lbServiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbServiceId.ForeColor = System.Drawing.Color.White;
            this.lbServiceId.Location = new System.Drawing.Point(794, 29);
            this.lbServiceId.Name = "lbServiceId";
            this.lbServiceId.Size = new System.Drawing.Size(151, 32);
            this.lbServiceId.TabIndex = 38;
            this.lbServiceId.Text = "Mã dịch vụ";
            // 
            // dtgvService
            // 
            this.dtgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvService.Location = new System.Drawing.Point(12, 12);
            this.dtgvService.Name = "dtgvService";
            this.dtgvService.RowHeadersWidth = 51;
            this.dtgvService.RowTemplate.Height = 24;
            this.dtgvService.Size = new System.Drawing.Size(760, 480);
            this.dtgvService.TabIndex = 36;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 15;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "XÓA";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 15;
            this.btnDelete.IdleFillColor = System.Drawing.Color.Red;
            this.btnDelete.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnDelete.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(1210, 224);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 60);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 15;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "SỬA";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 15;
            this.btnEdit.IdleFillColor = System.Drawing.Color.Red;
            this.btnEdit.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnEdit.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(1060, 224);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 60);
            this.btnEdit.TabIndex = 49;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 15;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "THÊM";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 15;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Red;
            this.btnAdd.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(910, 224);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 60);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbServiceId
            // 
            this.tbServiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbServiceId.Location = new System.Drawing.Point(1033, 29);
            this.tbServiceId.Name = "tbServiceId";
            this.tbServiceId.Size = new System.Drawing.Size(317, 38);
            this.tbServiceId.TabIndex = 51;
            // 
            // tbServicePrice
            // 
            this.tbServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbServicePrice.Location = new System.Drawing.Point(1033, 147);
            this.tbServicePrice.Name = "tbServicePrice";
            this.tbServicePrice.Size = new System.Drawing.Size(317, 38);
            this.tbServicePrice.TabIndex = 52;
            // 
            // tbServiceName
            // 
            this.tbServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbServiceName.Location = new System.Drawing.Point(1033, 88);
            this.tbServiceName.Name = "tbServiceName";
            this.tbServiceName.Size = new System.Drawing.Size(317, 38);
            this.tbServiceName.TabIndex = 53;
            // 
            // frmServiceManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.tbServiceName);
            this.Controls.Add(this.tbServicePrice);
            this.Controls.Add(this.tbServiceId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mummyTextbox);
            this.Controls.Add(this.lbServicePrice);
            this.Controls.Add(this.lbServiceName);
            this.Controls.Add(this.lbServiceId);
            this.Controls.Add(this.dtgvService);
            this.Name = "frmServiceManaging";
            this.Text = "frmServiceManaging";
            this.Load += new System.EventHandler(this.frmServiceManaging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.TextBox mummyTextbox;
        private System.Windows.Forms.Label lbServicePrice;
        private System.Windows.Forms.Label lbServiceName;
        private System.Windows.Forms.Label lbServiceId;
        private System.Windows.Forms.DataGridView dtgvService;
        private System.Windows.Forms.TextBox tbServiceId;
        private System.Windows.Forms.TextBox tbServicePrice;
        private System.Windows.Forms.TextBox tbServiceName;
    }
}