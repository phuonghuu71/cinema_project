using CSMS.DAL;
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
    public partial class frmStatis : Form
    {
        BindingSource statisList = new BindingSource();

        public frmStatis()
        {
            InitializeComponent();

        }
        private void frmStatis_Load(object sender, EventArgs e)
        {
            Loaddtgv();
            loadCrystalReport();
        }

        #region dtgv
        public void Loaddtgv()
        {
            dtgvStatis.DataSource = statisList;
            LoadListStatis();
        }


        void LoadListStatis()
        {
            DateTime now = DateTime.Now;
            dtpFrom.Value = new DateTime(now.Year, now.Month, 1);
            dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1);

            String start = dtpFrom.Value.ToString("yyyy-M-dd");
            String end = dtpTo.Value.ToString("yyyy-M-dd");

            statisList.DataSource = StatisticalDAL.Instance.GetStatisticalListByDate(start, end);
            this.dtgvStatis.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatis.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatis.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatis.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStatis.Columns[2].HeaderText = "GIÁ VÉ";
            this.dtgvStatis.Columns[0].HeaderText = "TÊN RẠP";
            this.dtgvStatis.Columns[1].HeaderText = "TÊN PHÒNG CHIẾU";
            this.dtgvStatis.Columns[3].HeaderText = "NGÀY CHIẾU";
        }





        #endregion

        private void btnStatis_Click(object sender, EventArgs e)
        {
            String start = dtpFrom.Value.ToString("yyyy-M-dd");
            String end = dtpTo.Value.ToString("yyyy-M-dd");
            loadCrystalReport();
            statisList.DataSource = StatisticalDAL.Instance.GetStatisticalListByDate(start, end);
        }
        private void loadCrystalReport()
        {
            CinemaReport rp = new CinemaReport();
            rp.SetDataSource(statisList);
            report.ReportSource = rp;
            report.Refresh();
        }

    }
}
