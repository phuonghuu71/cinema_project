using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class ScreenDAL
    {
        #region instance
        private static ScreenDAL instance;

        public static ScreenDAL Instance
        {
            get { if (instance == null) instance = new ScreenDAL(); return instance; }
            private set { instance = value; }
        }

        private ScreenDAL() { }
        #endregion

        public static int seatWidth = 45;
        public static int seatHeight = 60;

        #region getlistSeat
        public List<ScreenAndSeat> getListSeat(String ScreenName, String theaterName)
        {
            List<ScreenAndSeat> screenList = new List<ScreenAndSeat>();
            string query = string.Format("SELECT PHONGCHIEU.MAPHONGCHIEU, TENPHONGCHIEU, SOCOT, SOHANG, TINHTRANG " +
                "FROM PHONGCHIEU, GHE, RAPCHIEU " +
                "WHERE PHONGCHIEU.MAPHONGCHIEU = GHE.MAPHONGCHIEU AND PHONGCHIEU.MARAP = RAPCHIEU.MARAP AND TENPHONGCHIEU = '{0}' AND TENRAP = N'{1}'", ScreenName, theaterName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ScreenAndSeat screen = new ScreenAndSeat(item);
                screenList.Add(screen);
            }
            return screenList;
        }
        #endregion

        #region getListScreen
        public List<ScreenOnly> getListScreenByName(String tenRap)
        {
            List<ScreenOnly> screenList = new List<ScreenOnly>();
            string query = string.Format("SELECT * " +
                "FROM PHONGCHIEU, RAPCHIEU " +
                "WHERE PHONGCHIEU.MARAP = RAPCHIEU.MARAP AND TENRAP = N'{0}'", tenRap);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ScreenOnly screen = new ScreenOnly(item);
                screenList.Add(screen);
            }
            return screenList;
        }
        #endregion

        #region getScreenIdByName
        public int getTheaterIdByName(String screenName)
        {
            string query = string.Format("SELECT MARAP FROM RAPCHIEU WHERE TENRAP = N'{0}'", screenName);
            Object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }
        #endregion

        #region screenInsert
        public bool screenInsert(String screenName, int theaterId)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC ScreenInsert @TENPHONGCHIEU , @MARAP", new object[] { screenName, theaterId });
            return result > 0;
        }
        #endregion

        #region InsertScreenSeat
        public bool InsertScreenSeat(int column, int screenId)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("InsertScreenSeat @SOHANG , @MAPHONGCHIEU", new object[] { column, screenId });
            return result > 0;
        }
        #endregion

        #region getIdByScreenNameAndTheaterId
        public int getIdByScreenNameAndTheaterId(String screenName, int theaterId)
        {
            object myObj = DataProvider.Instance.ExecuteScalar("EXEC GetIdByScreenNameAndTheaterId @TENPHONGCHIEU , @MARAP", new object[] { screenName, theaterId });
            return (int)myObj;
        }
        #endregion

        #region deleteScreenAndSeatById
        public bool deleteScreenAndSeatById(int screenId)
        {
            int result =DataProvider.Instance.ExecuteNonQuery("EXEC deleteScreenAndSeatById @MAPHONGCHIEU", new object[] { screenId });
            return result > 0;
        }
        #endregion

    }
}
