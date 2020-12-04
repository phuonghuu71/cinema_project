using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class AccountDAL
    {
        #region instance
        private static AccountDAL instance;

        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }

        private AccountDAL() { }
        #endregion

        #region login
        public int login(string username, string pwd)
        {
            object result = DataProvider.Instance.ExecuteScalar("" +
                "SELECT dbo.login( @username , @password )", new object[] { username, pwd });
            return (int)result;
        }
        #endregion

        #region insert
        public bool insert(string username, string pwd)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC INsertStaff @TENDANGNHAP , @MATKHAU", new object[] { username, pwd });
            return result > 0;
        }
        #endregion

        #region checkExist
        public int checkExist(string username)
        {
            object result = DataProvider.Instance.ExecuteScalar("SELECT dbo.checkExist( @username )", new object[] { username });
            return (int)result;
        }
        #endregion

        #region getAccountInfoByUsername
        public Account GetAccountInfoByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TaiKhoan A, dbo.ThongTinTaiKhoan B WHERE A.TenDangNhap = B.TenDangNhap AND A.TenDangNhap = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        #endregion

        #region getAccountList
        public List<Account> getAccountList()
        {
            List<Account> accountList = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT A.TenDangNhap, MatKhau, LoaiTaiKhoan, HoTen, SoDienThoai, DiaChi, CMND, Tuoi, GioiTinh FROM TaiKhoan A, ThongTinTaiKhoan B WHERE A.TenDangNhap = B.TenDangNhap");
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                accountList.Add(account);
            }
            return accountList;
        }
        #endregion

        #region changePwd
        public bool changepwd(string username, string pwd)
        {
            string query = string.Format("UPDATE TaiKhoan SET MatKhau = HASHBYTES('MD5', '{0}') WHERE TenDangNhap = '{2}'", new object[] { pwd, username });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region changeAccountType
        public bool changeAccountType(string username, string loaiTK)
        {
            string query = string.Format("UPDATE TaiKhoan SET LoaiTaiKhoan = '{0}' WHERE TenDangNhap = '{1}'", new object[] { loaiTK, username });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region changeinfo
        public bool changeinfo(string name, string phone, string address, string cmnd, int age, string gender, string username)
        {
            string query = string.Format("UPDATE ThongTinTaiKhoan SET HoTen = N'{0}', SoDienThoai = '{1}', DiaChi = N'{2}', CMND = '{3}', Tuoi = '{4}', GioiTinh = N'{5}' WHERE TenDangNhap = '{6}'", new object[] { name, phone, address, cmnd, age, gender, username });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region deleteAccount
        public bool deleteAccount(string username)
        {
            string query = string.Format("DELETE FROM ThongTinTaiKhoan WHERE TenDangNhap = '{0}' DELETE FROM TaiKhoan WHERE TenDangNhap = '{1}'", new object[] { username, username });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

    }
}
