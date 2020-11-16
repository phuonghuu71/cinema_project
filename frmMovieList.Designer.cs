namespace CSMS
{
    partial class frmMovieList
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
            this.flpMovieList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpMovieList
            // 
            this.flpMovieList.AutoScroll = true;
            this.flpMovieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMovieList.Location = new System.Drawing.Point(0, 0);
            this.flpMovieList.Name = "flpMovieList";
            this.flpMovieList.Size = new System.Drawing.Size(1103, 633);
            this.flpMovieList.TabIndex = 0;
            // 
            // frmMovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1103, 633);
            this.Controls.Add(this.flpMovieList);
            this.Name = "frmMovieList";
            this.Text = "frmMovieList";
            this.Load += new System.EventHandler(this.frmMovieList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMovieList;
    }
}