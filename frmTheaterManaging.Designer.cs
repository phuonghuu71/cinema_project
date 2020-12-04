namespace CSMS
{
    partial class frmTheaterManaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheaterManaging));
            this.dtgvTheater = new System.Windows.Forms.DataGridView();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.tbTheaterName = new System.Windows.Forms.TextBox();
            this.tbTheaterID = new System.Windows.Forms.TextBox();
            this.lbTheaterID = new System.Windows.Forms.Label();
            this.tbTheaterAddress = new System.Windows.Forms.TextBox();
            this.lbTheaterAddress = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheater)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTheater
            // 
            this.dtgvTheater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTheater.Location = new System.Drawing.Point(12, 12);
            this.dtgvTheater.Name = "dtgvTheater";
            this.dtgvTheater.RowHeadersWidth = 51;
            this.dtgvTheater.RowTemplate.Height = 24;
            this.dtgvTheater.Size = new System.Drawing.Size(700, 500);
            this.dtgvTheater.TabIndex = 0;
            // 
            // lbTheaterName
            // 
            this.lbTheaterName.AutoSize = true;
            this.lbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterName.ForeColor = System.Drawing.Color.White;
            this.lbTheaterName.Location = new System.Drawing.Point(732, 85);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Size = new System.Drawing.Size(123, 32);
            this.lbTheaterName.TabIndex = 9;
            this.lbTheaterName.Text = "Tên Rạp";
            // 
            // tbTheaterName
            // 
            this.tbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbTheaterName.Location = new System.Drawing.Point(899, 82);
            this.tbTheaterName.Name = "tbTheaterName";
            this.tbTheaterName.Size = new System.Drawing.Size(451, 38);
            this.tbTheaterName.TabIndex = 10;
            // 
            // tbTheaterID
            // 
            this.tbTheaterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbTheaterID.Location = new System.Drawing.Point(899, 12);
            this.tbTheaterID.Name = "tbTheaterID";
            this.tbTheaterID.ReadOnly = true;
            this.tbTheaterID.Size = new System.Drawing.Size(451, 38);
            this.tbTheaterID.TabIndex = 12;
            // 
            // lbTheaterID
            // 
            this.lbTheaterID.AutoSize = true;
            this.lbTheaterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterID.ForeColor = System.Drawing.Color.White;
            this.lbTheaterID.Location = new System.Drawing.Point(732, 15);
            this.lbTheaterID.Name = "lbTheaterID";
            this.lbTheaterID.Size = new System.Drawing.Size(113, 32);
            this.lbTheaterID.TabIndex = 11;
            this.lbTheaterID.Text = "Mã Rạp";
            // 
            // tbTheaterAddress
            // 
            this.tbTheaterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbTheaterAddress.Location = new System.Drawing.Point(899, 152);
            this.tbTheaterAddress.Name = "tbTheaterAddress";
            this.tbTheaterAddress.Size = new System.Drawing.Size(451, 38);
            this.tbTheaterAddress.TabIndex = 14;
            // 
            // lbTheaterAddress
            // 
            this.lbTheaterAddress.AutoSize = true;
            this.lbTheaterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterAddress.ForeColor = System.Drawing.Color.White;
            this.lbTheaterAddress.Location = new System.Drawing.Point(732, 155);
            this.lbTheaterAddress.Name = "lbTheaterAddress";
            this.lbTheaterAddress.Size = new System.Drawing.Size(161, 32);
            this.lbTheaterAddress.TabIndex = 13;
            this.lbTheaterAddress.Text = "Địa chỉ Rạp";
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
            this.btnAdd.Location = new System.Drawing.Point(899, 198);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 60);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(1054, 198);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 60);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(1209, 198);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 60);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmTheaterManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbTheaterAddress);
            this.Controls.Add(this.lbTheaterAddress);
            this.Controls.Add(this.tbTheaterID);
            this.Controls.Add(this.lbTheaterID);
            this.Controls.Add(this.tbTheaterName);
            this.Controls.Add(this.lbTheaterName);
            this.Controls.Add(this.dtgvTheater);
            this.Name = "frmTheaterManaging";
            this.Text = "frmTheaterManaging";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTheater;
        private System.Windows.Forms.Label lbTheaterName;
        private System.Windows.Forms.TextBox tbTheaterName;
        private System.Windows.Forms.TextBox tbTheaterID;
        private System.Windows.Forms.Label lbTheaterID;
        private System.Windows.Forms.TextBox tbTheaterAddress;
        private System.Windows.Forms.Label lbTheaterAddress;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
    }
}