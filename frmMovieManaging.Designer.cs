namespace CSMS
{
    partial class frmMovieManaging
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
            this.tcMovieManaging = new MaterialSkin.Controls.MaterialTabControl();
            this.tpAddMovie = new System.Windows.Forms.TabPage();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.lbPreviewChanged = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbPreviewEnd = new System.Windows.Forms.Label();
            this.lbPreviewStart = new System.Windows.Forms.Label();
            this.lbPreviewFormat = new System.Windows.Forms.Label();
            this.lbPreviewTitle = new System.Windows.Forms.Label();
            this.lbPreviewDescription = new System.Windows.Forms.Label();
            this.lbPreviewRated = new System.Windows.Forms.Label();
            this.lbPreviewLanguage = new System.Windows.Forms.Label();
            this.lbPreviewTime = new System.Windows.Forms.Label();
            this.lbPreviewDirector = new System.Windows.Forms.Label();
            this.lbPreviewCategory = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lbFormat = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lbTo = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbRated = new System.Windows.Forms.TextBox();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbRated = new System.Windows.Forms.Label();
            this.lbLanguage = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDirector = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbImage = new System.Windows.Forms.Label();
            this.tpEditMovie = new System.Windows.Forms.TabPage();
            this.tabSelectorMovieManaging = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcMovieManaging.SuspendLayout();
            this.tpAddMovie.SuspendLayout();
            this.panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.panelInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMovieManaging
            // 
            this.tcMovieManaging.Controls.Add(this.tpAddMovie);
            this.tcMovieManaging.Controls.Add(this.tpEditMovie);
            this.tcMovieManaging.Depth = 0;
            this.tcMovieManaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMovieManaging.Location = new System.Drawing.Point(0, 23);
            this.tcMovieManaging.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcMovieManaging.Name = "tcMovieManaging";
            this.tcMovieManaging.SelectedIndex = 0;
            this.tcMovieManaging.Size = new System.Drawing.Size(1362, 730);
            this.tcMovieManaging.TabIndex = 1;
            // 
            // tpAddMovie
            // 
            this.tpAddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.tpAddMovie.Controls.Add(this.panelPreview);
            this.tpAddMovie.Controls.Add(this.panelInsert);
            this.tpAddMovie.Location = new System.Drawing.Point(4, 25);
            this.tpAddMovie.Name = "tpAddMovie";
            this.tpAddMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddMovie.Size = new System.Drawing.Size(1354, 701);
            this.tpAddMovie.TabIndex = 0;
            this.tpAddMovie.Text = "Thêm phim";
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panelPreview.Controls.Add(this.lbPreviewChanged);
            this.panelPreview.Controls.Add(this.lbPreviewEnd);
            this.panelPreview.Controls.Add(this.lbPreviewStart);
            this.panelPreview.Controls.Add(this.lbPreviewFormat);
            this.panelPreview.Controls.Add(this.lbPreviewTitle);
            this.panelPreview.Controls.Add(this.lbPreviewDescription);
            this.panelPreview.Controls.Add(this.lbPreviewRated);
            this.panelPreview.Controls.Add(this.lbPreviewLanguage);
            this.panelPreview.Controls.Add(this.lbPreviewTime);
            this.panelPreview.Controls.Add(this.lbPreviewDirector);
            this.panelPreview.Controls.Add(this.lbPreviewCategory);
            this.panelPreview.Controls.Add(this.pbPoster);
            this.panelPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPreview.Location = new System.Drawing.Point(641, 3);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(710, 695);
            this.panelPreview.TabIndex = 2;
            // 
            // lbPreviewChanged
            // 
            this.lbPreviewChanged.AutoSize = true;
            this.lbPreviewChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewChanged.ForeColor = System.Drawing.Color.White;
            this.lbPreviewChanged.Location = new System.Drawing.Point(850, 650);
            this.lbPreviewChanged.Name = "lbPreviewChanged";
            this.lbPreviewChanged.Size = new System.Drawing.Size(137, 25);
            this.lbPreviewChanged.TabIndex = 27;
            this.lbPreviewChanged.Text = "Bản xem trước";
            // 
            // lbPreviewEnd
            // 
            this.lbPreviewEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewEnd.ForeColor = System.Drawing.Color.White;
            this.lbPreviewEnd.Location = new System.Drawing.Point(20, 545);
            this.lbPreviewEnd.Name = "lbPreviewEnd";
            this.lbPreviewEnd.Size = new System.Drawing.Size(300, 35);
            this.lbPreviewEnd.TabIndex = 26;
            // 
            // lbPreviewStart
            // 
            this.lbPreviewStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewStart.ForeColor = System.Drawing.Color.White;
            this.lbPreviewStart.Location = new System.Drawing.Point(20, 495);
            this.lbPreviewStart.Name = "lbPreviewStart";
            this.lbPreviewStart.Size = new System.Drawing.Size(300, 35);
            this.lbPreviewStart.TabIndex = 25;
            // 
            // lbPreviewFormat
            // 
            this.lbPreviewFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewFormat.ForeColor = System.Drawing.Color.White;
            this.lbPreviewFormat.Location = new System.Drawing.Point(20, 445);
            this.lbPreviewFormat.Name = "lbPreviewFormat";
            this.lbPreviewFormat.Size = new System.Drawing.Size(300, 35);
            this.lbPreviewFormat.TabIndex = 24;
            // 
            // lbPreviewTitle
            // 
            this.lbPreviewTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewTitle.ForeColor = System.Drawing.Color.White;
            this.lbPreviewTitle.Location = new System.Drawing.Point(340, 15);
            this.lbPreviewTitle.Name = "lbPreviewTitle";
            this.lbPreviewTitle.Size = new System.Drawing.Size(355, 30);
            this.lbPreviewTitle.TabIndex = 14;
            // 
            // lbPreviewDescription
            // 
            this.lbPreviewDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewDescription.ForeColor = System.Drawing.Color.White;
            this.lbPreviewDescription.Location = new System.Drawing.Point(340, 285);
            this.lbPreviewDescription.Name = "lbPreviewDescription";
            this.lbPreviewDescription.Size = new System.Drawing.Size(355, 295);
            this.lbPreviewDescription.TabIndex = 13;
            // 
            // lbPreviewRated
            // 
            this.lbPreviewRated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewRated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewRated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewRated.ForeColor = System.Drawing.Color.White;
            this.lbPreviewRated.Location = new System.Drawing.Point(340, 240);
            this.lbPreviewRated.Name = "lbPreviewRated";
            this.lbPreviewRated.Size = new System.Drawing.Size(355, 30);
            this.lbPreviewRated.TabIndex = 12;
            // 
            // lbPreviewLanguage
            // 
            this.lbPreviewLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewLanguage.ForeColor = System.Drawing.Color.White;
            this.lbPreviewLanguage.Location = new System.Drawing.Point(340, 195);
            this.lbPreviewLanguage.Name = "lbPreviewLanguage";
            this.lbPreviewLanguage.Size = new System.Drawing.Size(355, 30);
            this.lbPreviewLanguage.TabIndex = 11;
            // 
            // lbPreviewTime
            // 
            this.lbPreviewTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewTime.ForeColor = System.Drawing.Color.White;
            this.lbPreviewTime.Location = new System.Drawing.Point(340, 150);
            this.lbPreviewTime.Name = "lbPreviewTime";
            this.lbPreviewTime.Size = new System.Drawing.Size(355, 30);
            this.lbPreviewTime.TabIndex = 10;
            // 
            // lbPreviewDirector
            // 
            this.lbPreviewDirector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewDirector.ForeColor = System.Drawing.Color.White;
            this.lbPreviewDirector.Location = new System.Drawing.Point(340, 60);
            this.lbPreviewDirector.Name = "lbPreviewDirector";
            this.lbPreviewDirector.Size = new System.Drawing.Size(355, 30);
            this.lbPreviewDirector.TabIndex = 9;
            // 
            // lbPreviewCategory
            // 
            this.lbPreviewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.lbPreviewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPreviewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreviewCategory.ForeColor = System.Drawing.Color.White;
            this.lbPreviewCategory.Location = new System.Drawing.Point(340, 105);
            this.lbPreviewCategory.Name = "lbPreviewCategory";
            this.lbPreviewCategory.Size = new System.Drawing.Size(355, 30);
            this.lbPreviewCategory.TabIndex = 8;
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(25, 15);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(300, 400);
            this.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoster.TabIndex = 0;
            this.pbPoster.TabStop = false;
            // 
            // panelInsert
            // 
            this.panelInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panelInsert.Controls.Add(this.btnAddMovie);
            this.panelInsert.Controls.Add(this.cbFormat);
            this.panelInsert.Controls.Add(this.lbFormat);
            this.panelInsert.Controls.Add(this.dtpTo);
            this.panelInsert.Controls.Add(this.dtpFrom);
            this.panelInsert.Controls.Add(this.lbTo);
            this.panelInsert.Controls.Add(this.lbFrom);
            this.panelInsert.Controls.Add(this.lbDate);
            this.panelInsert.Controls.Add(this.btnUpload);
            this.panelInsert.Controls.Add(this.tbDescription);
            this.panelInsert.Controls.Add(this.tbRated);
            this.panelInsert.Controls.Add(this.tbLanguage);
            this.panelInsert.Controls.Add(this.tbTime);
            this.panelInsert.Controls.Add(this.tbCategory);
            this.panelInsert.Controls.Add(this.tbDirector);
            this.panelInsert.Controls.Add(this.tbTitle);
            this.panelInsert.Controls.Add(this.lbDescription);
            this.panelInsert.Controls.Add(this.lbRated);
            this.panelInsert.Controls.Add(this.lbLanguage);
            this.panelInsert.Controls.Add(this.lbTime);
            this.panelInsert.Controls.Add(this.lbDirector);
            this.panelInsert.Controls.Add(this.lbCategory);
            this.panelInsert.Controls.Add(this.lbTitle);
            this.panelInsert.Controls.Add(this.lbImage);
            this.panelInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInsert.Location = new System.Drawing.Point(3, 3);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(530, 695);
            this.panelInsert.TabIndex = 1;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Red;
            this.btnAddMovie.FlatAppearance.BorderSize = 0;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddMovie.ForeColor = System.Drawing.Color.White;
            this.btnAddMovie.Location = new System.Drawing.Point(150, 650);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(150, 40);
            this.btnAddMovie.TabIndex = 27;
            this.btnAddMovie.Text = "Thêm phim";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // cbFormat
            // 
            this.cbFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(400, 380);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(105, 33);
            this.cbFormat.TabIndex = 22;
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // lbFormat
            // 
            this.lbFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbFormat.ForeColor = System.Drawing.Color.White;
            this.lbFormat.Location = new System.Drawing.Point(280, 380);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(110, 35);
            this.lbFormat.TabIndex = 21;
            this.lbFormat.Text = "Định dạng:";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpTo.Location = new System.Drawing.Point(150, 600);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(355, 30);
            this.dtpTo.TabIndex = 20;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpFrom.Location = new System.Drawing.Point(150, 500);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(355, 30);
            this.dtpFrom.TabIndex = 19;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // lbTo
            // 
            this.lbTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTo.ForeColor = System.Drawing.Color.White;
            this.lbTo.Location = new System.Drawing.Point(145, 550);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(137, 30);
            this.lbTo.TabIndex = 18;
            this.lbTo.Text = "Đến:";
            // 
            // lbFrom
            // 
            this.lbFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbFrom.ForeColor = System.Drawing.Color.White;
            this.lbFrom.Location = new System.Drawing.Point(145, 460);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(137, 30);
            this.lbFrom.TabIndex = 17;
            this.lbFrom.Text = "Từ:";
            // 
            // lbDate
            // 
            this.lbDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(5, 460);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(137, 37);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "Ngày:";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Red;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(150, 380);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 40);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "Tải lên";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDescription.Location = new System.Drawing.Point(150, 285);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(355, 80);
            this.tbDescription.TabIndex = 14;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // tbRated
            // 
            this.tbRated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbRated.Location = new System.Drawing.Point(150, 240);
            this.tbRated.Name = "tbRated";
            this.tbRated.Size = new System.Drawing.Size(355, 30);
            this.tbRated.TabIndex = 13;
            this.tbRated.TextChanged += new System.EventHandler(this.tbRated_TextChanged);
            // 
            // tbLanguage
            // 
            this.tbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbLanguage.Location = new System.Drawing.Point(150, 195);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(355, 30);
            this.tbLanguage.TabIndex = 12;
            this.tbLanguage.TextChanged += new System.EventHandler(this.tbLanguage_TextChanged);
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTime.Location = new System.Drawing.Point(150, 150);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(355, 30);
            this.tbTime.TabIndex = 11;
            this.tbTime.TextChanged += new System.EventHandler(this.tbTime_TextChanged);
            // 
            // tbCategory
            // 
            this.tbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbCategory.Location = new System.Drawing.Point(150, 105);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(355, 30);
            this.tbCategory.TabIndex = 10;
            this.tbCategory.TextChanged += new System.EventHandler(this.tbCategory_TextChanged);
            // 
            // tbDirector
            // 
            this.tbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbDirector.Location = new System.Drawing.Point(150, 60);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(355, 30);
            this.tbDirector.TabIndex = 9;
            this.tbDirector.TextChanged += new System.EventHandler(this.tbDirector_TextChanged);
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbTitle.Location = new System.Drawing.Point(150, 15);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(355, 30);
            this.tbTitle.TabIndex = 8;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // lbDescription
            // 
            this.lbDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(5, 285);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(137, 37);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Nội dung:";
            // 
            // lbRated
            // 
            this.lbRated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRated.ForeColor = System.Drawing.Color.White;
            this.lbRated.Location = new System.Drawing.Point(5, 240);
            this.lbRated.Name = "lbRated";
            this.lbRated.Size = new System.Drawing.Size(137, 37);
            this.lbRated.TabIndex = 6;
            this.lbRated.Text = "Rated:";
            // 
            // lbLanguage
            // 
            this.lbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLanguage.ForeColor = System.Drawing.Color.White;
            this.lbLanguage.Location = new System.Drawing.Point(5, 195);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(137, 37);
            this.lbLanguage.TabIndex = 5;
            this.lbLanguage.Text = "Ngôn ngữ:";
            // 
            // lbTime
            // 
            this.lbTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(5, 150);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(137, 37);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Thời lượng:";
            // 
            // lbDirector
            // 
            this.lbDirector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDirector.ForeColor = System.Drawing.Color.White;
            this.lbDirector.Location = new System.Drawing.Point(5, 60);
            this.lbDirector.Name = "lbDirector";
            this.lbDirector.Size = new System.Drawing.Size(137, 37);
            this.lbDirector.TabIndex = 3;
            this.lbDirector.Text = "Đạo diễn:";
            // 
            // lbCategory
            // 
            this.lbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCategory.ForeColor = System.Drawing.Color.White;
            this.lbCategory.Location = new System.Drawing.Point(5, 105);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(137, 37);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Thể loại:";
            // 
            // lbTitle
            // 
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(5, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(137, 37);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tiêu đề:";
            // 
            // lbImage
            // 
            this.lbImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbImage.ForeColor = System.Drawing.Color.White;
            this.lbImage.Location = new System.Drawing.Point(5, 380);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(137, 37);
            this.lbImage.TabIndex = 0;
            this.lbImage.Text = "Hình ảnh:";
            // 
            // tpEditMovie
            // 
            this.tpEditMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.tpEditMovie.Location = new System.Drawing.Point(4, 25);
            this.tpEditMovie.Name = "tpEditMovie";
            this.tpEditMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditMovie.Size = new System.Drawing.Size(1894, 931);
            this.tpEditMovie.TabIndex = 1;
            this.tpEditMovie.Text = "EDIT PHIM";
            // 
            // tabSelectorMovieManaging
            // 
            this.tabSelectorMovieManaging.BaseTabControl = this.tcMovieManaging;
            this.tabSelectorMovieManaging.Depth = 0;
            this.tabSelectorMovieManaging.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelectorMovieManaging.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabSelectorMovieManaging.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorMovieManaging.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMovieManaging.Name = "tabSelectorMovieManaging";
            this.tabSelectorMovieManaging.Size = new System.Drawing.Size(1362, 23);
            this.tabSelectorMovieManaging.TabIndex = 2;
            // 
            // frmMovieManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.tcMovieManaging);
            this.Controls.Add(this.tabSelectorMovieManaging);
            this.Name = "frmMovieManaging";
            this.Text = "frmMovieManaging";
            this.Load += new System.EventHandler(this.frmMovieManaging_Load);
            this.tcMovieManaging.ResumeLayout(false);
            this.tpAddMovie.ResumeLayout(false);
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tcMovieManaging;
        private System.Windows.Forms.TabPage tpAddMovie;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Label lbPreviewEnd;
        private System.Windows.Forms.Label lbPreviewStart;
        private System.Windows.Forms.Label lbPreviewFormat;
        private System.Windows.Forms.Label lbPreviewTitle;
        private System.Windows.Forms.Label lbPreviewDescription;
        private System.Windows.Forms.Label lbPreviewRated;
        private System.Windows.Forms.Label lbPreviewLanguage;
        private System.Windows.Forms.Label lbPreviewTime;
        private System.Windows.Forms.Label lbPreviewDirector;
        private System.Windows.Forms.Label lbPreviewCategory;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbRated;
        private System.Windows.Forms.TextBox tbLanguage;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbRated;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDirector;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.TabPage tpEditMovie;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMovieManaging;
        private Bunifu.Framework.UI.BunifuCustomLabel lbPreviewChanged;
    }
}