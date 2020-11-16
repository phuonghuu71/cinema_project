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
        public frmMovieManaging()
        {
            InitializeComponent();
        }
        private void frmMovieManaging_Load(object sender, EventArgs e)
        {
            cbFormatLoad();
            dtpGet();
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
        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPreviewFormat.Text = "Định dạng: " + cbFormat.Text;
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
        #region add_movie
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
            string message, title_mes;
            if (title == ""||director == "" || category == "" || dayfrom == "" || dayto == "" || time == "" || language == "" || rated == "" || description == ""||cbFormat.Text==""||imageLocation=="")
            {
                message = "Xin hãy nhập đủ";
                title_mes = "Nhập thiếu dữ liệu";
                MessageBox.Show(message, title_mes);
            }
            else
            {
                List<Format> ml = MoviesDAL.Instance.getFormat();
                MoviesDAL.Instance.insertMovie(title, imageLocation, director, category, dayfrom, dayto, time, language, rated, description, cbFormat.SelectedIndex+1);
                message = "Nhập phim thành công";
                title_mes = "Thành công";
                MessageBox.Show(message, title_mes);
            }
        }
        #endregion

        public void cbFormatLoad()
        {
            List<Format> ml = MoviesDAL.Instance.getFormat();
            cbFormat.DataSource = ml;
            cbFormat.DisplayMember = "TENDINHDANG";
        }

    }
}
