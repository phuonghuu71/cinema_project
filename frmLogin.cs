using CSMS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
    public partial class frmLogin : Form
    {
        private static string salt = "key";
        public frmLogin()
        {
            InitializeComponent();
        }
        private void lbForgotPassword_MouseHover(object sender, EventArgs e)
        {
            lbForgotPassword.ForeColor = Color.Red;
        }

        private void lbForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lbForgotPassword.ForeColor = Color.White;
        }

        private void lbSignUp_MouseHover(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.Red;
        }

        private void lbSignUp_MouseLeave(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.White;
        }

        private string GenerateHash(string pwd)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(pwd + salt);
            SHA256Managed sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pwd = txtPassword.Text;
            string hash = GenerateHash(pwd);
            if(AccountDAL.Instance.login(username, pwd) == 1)
            {
                MessageBox.Show("Đăng nhập thành công", "Thành công");
                this.Hide();
                frmMainInterface df = new frmMainInterface();
                df.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thất bại");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister df = new frmRegister();
            df.ShowDialog();
            this.Close();
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
