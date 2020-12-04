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
    public partial class frmChangePwd : Form
    {
        private Account getInfo;

        public Account GetInfo { get => getInfo; set => getInfo = value; }

        public frmChangePwd(Account info)
        {
            this.GetInfo = info;
            InitializeComponent();
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            string oldPwd = txtOldPwd.Text;
            string newPwd = txtNewPwd.Text;
            if(AccountDAL.Instance.login(this.getInfo.TenDangNhap, oldPwd) == 1)
            {
                AccountDAL.Instance.changepwd(this.GetInfo.TenDangNhap, newPwd);
                MessageBox.Show("Đổi mật khẩu thành công", "Thành công");
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Lỗi");
            }
        }
    }
}
