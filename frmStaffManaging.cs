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
    public partial class frmStaffManaging : Form
    {
        BindingSource accountList = new BindingSource();
        public frmStaffManaging()
        {
            InitializeComponent();
        }
        private void frmStaffManaging_Load(object sender, EventArgs e)
        {
            Loaddtgv();
            AddAccountBinding();
        }

        #region dtgv
        public void Loaddtgv()
        {
            dtgvStaffInfo.DataSource = accountList;
            LoadListAccount();
        }

        void AddAccountBinding()
        {
            tbUsername.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            tbAccountType.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "LoaiTK", true, DataSourceUpdateMode.Never));
            tbName.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            tbPhone.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            tbAddress.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            tbCMND.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            tbAge.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "Tuoi", true, DataSourceUpdateMode.Never));
            tbGender.DataBindings.Add(new Binding("Text", dtgvStaffInfo.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
        }

        void LoadListAccount()
        {
            accountList.DataSource = AccountDAL.Instance.getAccountList();
            this.dtgvStaffInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dtgvStaffInfo.Columns[0].HeaderText = "Tên Đăng Nhập";
            this.dtgvStaffInfo.Columns[1].HeaderText = "Mật Khẩu";
            this.dtgvStaffInfo.Columns[2].HeaderText = "Loại Tài Khoản";
            this.dtgvStaffInfo.Columns[3].Visible = false;
            this.dtgvStaffInfo.Columns[4].Visible = false;
            this.dtgvStaffInfo.Columns[5].Visible = false;
            this.dtgvStaffInfo.Columns[6].Visible = false;
            this.dtgvStaffInfo.Columns[7].Visible = false;
            this.dtgvStaffInfo.Columns[8].Visible = false;
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string pwd = tbPassword.Text;
            string accountType = tbAccountType.Text;
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;
            string cmnd = tbCMND.Text;
            int age = int.Parse(tbAge.Text.ToString());
            string gender = tbGender.Text;
            AccountDAL.Instance.changeAccountType(username, accountType);
            AccountDAL.Instance.changeinfo(name, phone, address, cmnd, age, gender, username);
            MessageBox.Show("Đổi thông tin thành công", "Thành công");
            Loaddtgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string loaiTK = tbAccountType.Text;
            if(loaiTK == "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản admin", "Lỗi");
                return;
            }
            AccountDAL.Instance.deleteAccount(username);
            MessageBox.Show("Xóa tài khoản thành công", "Thành công");
            Loaddtgv();
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string pwd = tbPassword.Text;
            string accountType = tbAccountType.Text;
            AccountDAL.Instance.changepwd(username, pwd);
            MessageBox.Show("Đổi mật khẩu thành công", "Thành công");
        }
    }
}
