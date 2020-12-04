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
    public partial class frmStaffInfo : Form
    {
        private Account getInfo;

        public Account GetInfo { get => getInfo; set => getInfo = value; }

        public frmStaffInfo(Account info)
        {
            InitializeComponent();
            this.GetInfo = info;
        }

        private void frmStaffInfo_Load(object sender, EventArgs e)
        {
            loadAccount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;
            string cmnd = tbCMND.Text;
            int age = int.Parse(tbAge.Text.ToString());
            string gender = tbGender.Text;
            AccountDAL.Instance.changeinfo(name, phone, address, cmnd, age, gender, this.GetInfo.TenDangNhap);
            MessageBox.Show("Đổi thông tin thành công", "Thành công");
            loadAccount();
        }
        private void loadAccount()
        {
            Account account = AccountDAL.Instance.GetAccountInfoByUserName(this.GetInfo.TenDangNhap); 
            tbName.Text = account.HoTen;
            tbPhone.Text = account.Sdt;
            tbAddress.Text = account.DiaChi;
            tbCMND.Text = account.CMND;
            tbAge.Text = account.Tuoi.ToString();
            tbGender.Text = account.GioiTinh;
        }
    }
}
