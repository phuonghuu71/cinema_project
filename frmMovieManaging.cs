using CSMS.DAL;
using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
    public partial class frmMovieManaging : Form
    {
        String imageLocation = "";
        BindingSource movieList = new BindingSource();
        public frmMovieManaging()
        {
            InitializeComponent();
        }
        private void frmMovieManaging_Load(object sender, EventArgs e)
        {
            dtpGet();
            Loaddtgv();
            AddDataBinding();
        }
        #region preview
        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            lbPreviewTitle.Text = tbTitle.Text;
        }

        private void tbDirector_TextChanged(object sender, EventArgs e)
        {
            lbPreviewDirector.Text = tbDirector.Text;
        }

        private void tbCategory_TextChanged(object sender, EventArgs e)
        {
            lbPreviewCategory.Text = tbCategory.Text;
        }

        private void tbTime_TextChanged(object sender, EventArgs e)
        {
            lbPreviewTime.Text = tbTime.Text;
        }

        private void tbLanguage_TextChanged(object sender, EventArgs e)
        {
            lbPreviewLanguage.Text = tbLanguage.Text;
        }

        private void tbRated_TextChanged(object sender, EventArgs e)
        {
            lbPreviewRated.Text = tbRated.Text;
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            lbPreviewDescription.Text = tbDescription.Text;
        }
        private void tbFormat_TextChanged(object sender, EventArgs e)
        {
            lbPreviewFormat.Text = "Định dạng: " + tbFormat.Text;
        }
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            lbPreviewStart.Text = "Khởi chiếu: " + dtpFrom.Value.ToString();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            lbPreviewEnd.Text = "Kết thúc: " + dtpTo.Value.ToString();
        }
        #endregion

        #region dtgv
        public void Loaddtgv()
        {
            dtgvMovie.DataSource = movieList;
            LoadListTheater();
        }

        public void AddDataBinding()
        {
            AddMovieBinding();
        }

        void AddMovieBinding()
        {
            tbTitleEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "TENPHIM", true, DataSourceUpdateMode.Never));
            tbDirectorEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "DAODIEN", true, DataSourceUpdateMode.Never));
            tbCategoryEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "THELOAI", true, DataSourceUpdateMode.Never));
            tbTimeEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "THOILUONG", true, DataSourceUpdateMode.Never));
            tbLanguageEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "NGONNGU", true, DataSourceUpdateMode.Never));
            tbRatedEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "RATED", true, DataSourceUpdateMode.Never));
            tbDescriptionEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "NOIDUNG", true, DataSourceUpdateMode.Never));
            tbFormatEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "DINHDANG", true, DataSourceUpdateMode.Never));
            dtpFromEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "KHOICHIEU", true, DataSourceUpdateMode.Never));
            dtpToEdit.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "KETTHUC", true, DataSourceUpdateMode.Never));
            labelMummy.DataBindings.Add(new Binding("Text", dtgvMovie.DataSource, "MAPHIM", true, DataSourceUpdateMode.Never));
        }

        void LoadListTheater()
        {
            movieList.DataSource = MoviesDAL.Instance.getListMovies();

            this.dtgvMovie.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvMovie.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvMovie.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvMovie.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvMovie.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvMovie.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.dtgvMovie.Columns[0].Visible = false;
            this.dtgvMovie.Columns[2].Visible = false;
            this.dtgvMovie.Columns[3].Visible = false;
            this.dtgvMovie.Columns[4].Visible = false;
            this.dtgvMovie.Columns[5].Visible = false;
            this.dtgvMovie.Columns[6].Visible = false;
            this.dtgvMovie.Columns[7].Visible = false;
            this.dtgvMovie.Columns[8].Visible = false;
            this.dtgvMovie.Columns[9].Visible = false;
            this.dtgvMovie.Columns[10].Visible = false;
            this.dtgvMovie.Columns[11].Visible = false;


        }

        #endregion

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pbPoster.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtpGet()
        {
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }
        #region button
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string director = tbDirector.Text;
            string category = tbCategory.Text;
            string dayfrom = dtpFrom.Value.Date.ToString("yyyyMMdd");
            string dayto = dtpTo.Value.Date.ToString("yyyyMMdd");
            string time = tbTime.Text;
            string language = tbLanguage.Text;
            string rated = tbRated.Text;
            string description = tbDescription.Text;
            string format = tbFormat.Text;
            string message, title_mes;
            if (title == ""||director == "" || category == "" || dayfrom == "" || dayto == "" || time == "" || language == "" || rated == "" || description == ""||tbFormat.Text==""||imageLocation=="")
            {
                message = "Xin hãy nhập đủ";
                title_mes = "Nhập thiếu dữ liệu";
                MessageBox.Show(message, title_mes);
            }
            else
            {
                MoviesDAL.Instance.insertMovie(title, imageLocation, director, category, dayfrom, dayto, time, language, rated, description, format);
                message = "Nhập phim thành công";
                title_mes = "Thành công";
                MessageBox.Show(message, title_mes);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string titleEdit = tbTitleEdit.Text;
            string directorEdit = tbDirectorEdit.Text;
            string categoryEdit = tbCategoryEdit.Text;
            string dayfromEdit = dtpFromEdit.Value.Date.ToString("yyyyMMdd");
            string daytoEdit = dtpToEdit.Value.Date.ToString("yyyyMMdd");
            string timeEdit = tbTimeEdit.Text;
            string languageEdit = tbLanguageEdit.Text;
            string ratedEdit = tbRatedEdit.Text;
            string descriptionEdit = tbDescriptionEdit.Text;
            string formatEdit = tbFormatEdit.Text;
            int movieIdEdit = Convert.ToInt32(labelMummy.Text);
            string message, title_mes;

            MoviesDAL.Instance.updateMovie(titleEdit, directorEdit, categoryEdit, dayfromEdit, daytoEdit, timeEdit, languageEdit, ratedEdit, descriptionEdit, formatEdit, movieIdEdit);
            message = "Sửa phim thành công";
            title_mes = "Thành công";
            MessageBox.Show(message, title_mes);
            Loaddtgv();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string movieName = tbTitleEdit.Text;
                MoviesDAL.Instance.deleteMovieByName(movieName);
                Loaddtgv();
            }
            catch { }
        }

        #endregion


    }
}
