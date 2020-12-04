using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class StatisticalDAL
    {
        #region instance
        private static StatisticalDAL instance;

        public static StatisticalDAL Instance
        {
            get { if (instance == null) instance = new StatisticalDAL(); return instance; }
            private set { instance = value; }
        }

        private StatisticalDAL() { }
        #endregion

        public bool insertStatistical(String theaterName, String screenName, String showtimeDate, Decimal money)
        {
            string query = string.Format("INSERT INTO THONGKE(TENRAP, TENPHONGCHIEU, NGAYCHIEU, GIAVE) " +
                "VALUES(N'{0}' , N'{1}' , N'{2}' , '{3}')", theaterName, screenName, showtimeDate, money);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<Statistical> GetStatisticalListByDate(String start, String end)
        {
            List<Statistical> statisList = new List<Statistical>();
            string query = "EXEC GetStatisByDate '" + start + "' , '" + end + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Statistical statis = new Statistical(item);
                statisList.Add(statis);
            }
            return statisList;
        }

    }

}
