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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void txtReEnterPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtReEnterPassword.isPassword = true;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin df = new frmLogin();
            df.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string usr = txtUsername.Text;
            string pwd = txtPassword.Text;
            string repwd = txtReEnterPassword.Text;
            if(pwd!=repwd)
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo");
            }
            else if(AccountDAL.Instance.checkExist(usr) == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
            }
            else
            {
                AccountDAL.Instance.insert(usr, pwd);
                MessageBox.Show("Thêm tài khoản thành công", "Thông báo");
            }
        }
    }
}
