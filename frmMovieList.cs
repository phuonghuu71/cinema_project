using CSMS.DAL;
using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
    public partial class frmMovieList : Form
    {
        public frmMovieList()
        {
            InitializeComponent();
            populateItem();
        }

        private void frmMovieList_Load(object sender, EventArgs e)
        {

        }
        private void populateItem()
        {
            List < Movies> ml = MoviesDAL.Instance.getListMovies();
            movieList[] mlUC = new movieList[ml.Count()]; 
            for(int i = 0; i < ml.Count(); i++)
            {
                mlUC[i] = new movieList();
                mlUC[i].Title = ml[i].TenPhim;
                mlUC[i].Poster = ml[i].ANh;
                mlUC[i].Director = ml[i].DaoDien;
                mlUC[i].Time = ml[i].ThoiLuong;
                mlUC[i].Genre = ml[i].TheLoai;
                mlUC[i].Language = ml[i].NgonNgu;
                mlUC[i].Rated = ml[i].RaTed;
                mlUC[i].Content = ml[i].NoiDung;
                mlUC[i].Format = ml[i].DinhDang;
                mlUC[i].Start = ml[i].KhoiChieu;
                mlUC[i].End = ml[i].KetThuc;
                flpMovieList.Controls.Add(mlUC[i]);
            }
        }
    }
}
