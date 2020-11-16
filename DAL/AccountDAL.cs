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


    }
}
