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
    public partial class frmTheaterManaging : Form
    {

        BindingSource theaterList = new BindingSource();

        public frmTheaterManaging()
        {
            InitializeComponent();
            Loaddtgv();
            AddTheaterBinding();
        }

        #region dtgv
        public void Loaddtgv()
        {
            dtgvTheater.DataSource = theaterList;
            LoadListTheater();
        }

        public void AddDataBinding()
        {
            AddTheaterBinding();
        }

        void AddTheaterBinding()
        {
            tbTheaterID.DataBindings.Add(new Binding("Text", dtgvTheater.DataSource, "MARAP", true, DataSourceUpdateMode.Never));
            tbTheaterName.DataBindings.Add(new Binding("Text", dtgvTheater.DataSource, "TENRAP", true, DataSourceUpdateMode.Never));
            tbTheaterAddress.DataBindings.Add(new Binding("Text", dtgvTheater.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
        }

        void LoadListTheater()
        {
            theaterList.DataSource = TheaterDAL.Instance.getTheaterList();
            this.dtgvTheater.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvTheater.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvTheater.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvTheater.Columns[0].HeaderText = "MÃ RẠP";
            this.dtgvTheater.Columns[1].HeaderText = "TÊN RẠP";
            this.dtgvTheater.Columns[2].HeaderText = "ĐỊA CHỈ";
        }

        #endregion

        #region insertTheater
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String tenRap = tbTheaterName.Text;
            String diaChi = tbTheaterAddress.Text;
            TheaterDAL.Instance.insertTheater(tenRap, diaChi);
            Loaddtgv();
        }


        #endregion

        #region updateTheater
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int maRap = Int32.Parse(tbTheaterID.Text);
            String tenRap = tbTheaterName.Text;
            String diaChi = tbTheaterAddress.Text;
            TheaterDAL.Instance.updateTheater(maRap, tenRap, diaChi);
            Loaddtgv();
        }
        #endregion

        #region deleteTheater
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int maRap = Int32.Parse(tbTheaterID.Text);
                TheaterDAL.Instance.deleteTheater(maRap);
                Loaddtgv();
            }
            catch
            {
                MessageBox.Show("Vui lòng xóa hết phòng của rạp trước", "Lỗi");
            }
        }
        #endregion

    }
}
