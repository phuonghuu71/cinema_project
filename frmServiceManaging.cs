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
    public partial class frmServiceManaging : Form
    {
        BindingSource serviceList = new BindingSource();
        public frmServiceManaging()
        {
            InitializeComponent();
        }

        private void frmServiceManaging_Load(object sender, EventArgs e)
        {
            Loaddtgv();
            AddServiceBinding();
        }

        #region dtgv
        public void Loaddtgv()
        {
            dtgvService.DataSource = serviceList;
            LoadListService();
        }

        void AddServiceBinding()
        {
            tbServiceId.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "MADV", true, DataSourceUpdateMode.Never));
            tbServiceName.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "TENDV", true, DataSourceUpdateMode.Never));
            tbServicePrice.DataBindings.Add(new Binding("Text", dtgvService.DataSource, "GIADV", true, DataSourceUpdateMode.Never));
        }

        void LoadListService()
        {
            serviceList.DataSource = ServicesDAL.Instance.GetServiceList();
            this.dtgvService.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvService.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvService.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvService.Columns[0].HeaderText = "MÃ DV";
            this.dtgvService.Columns[1].HeaderText = "TÊN DV";
            this.dtgvService.Columns[2].HeaderText = "GIÁ DV";
        }




        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int serviceId = int.Parse(tbServiceId.Text.ToString());
                string serviceName = tbServiceName.Text;
                Decimal servicePrice = Decimal.Parse(tbServicePrice.Text);
                ServicesDAL.Instance.insertService(serviceId, serviceName, servicePrice);
                MessageBox.Show("Thêm dịch vụ thành công", "Thành công");
                Loaddtgv();
            }
            catch { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int serviceId = int.Parse(tbServiceId.Text.ToString());
                string serviceName = tbServiceName.Text;
                Decimal servicePrice = Decimal.Parse(tbServicePrice.Text);
                ServicesDAL.Instance.updateService(serviceId, serviceName, servicePrice);
                MessageBox.Show("Cập nhật dịch vụ thành công", "Thành công");
                Loaddtgv();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int serviceId = int.Parse(tbServiceId.Text.ToString());
                ServicesDAL.Instance.deleteService(serviceId);
                MessageBox.Show("Xóa dịch vụ thành công", "Thành công");
                Loaddtgv();
            }
            catch { }
        }
    }
}
