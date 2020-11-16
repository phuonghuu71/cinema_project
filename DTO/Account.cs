using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Account
    {
        #region variable instance
        private String tenDangNhap;
        private String matKhau;
        #endregion

        #region getter_setter
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        #endregion

        #region constructor
        public Account(string tenDangNhap, string matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }
        #endregion

        public Account(DataRow row)
        {
            this.TenDangNhap = row["TENDANGNHAP"].ToString();
            this.MatKhau = row["MATKHAU"].ToString();
        }
    }
}
