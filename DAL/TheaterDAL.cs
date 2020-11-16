using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class TheaterDAL
    {
        #region instance
        private static TheaterDAL instance;

        public static TheaterDAL Instance
        {
            get { if (instance == null) instance = new TheaterDAL(); return instance; }
            private set { instance = value; }
        }

        private TheaterDAL() { }
        #endregion

        #region getTheaterList
        public List<Theater> getTheaterList()
        {
            List<Theater> theaterList = new List<Theater>();

            string query = "EXEC GetTheaterList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Theater theater = new Theater(item);
                theaterList.Add(theater);
            }
            return theaterList;
        }
        #endregion

        #region insertTheater
        public void insertTheater(String tenRap, String diaChi)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC TheaterListInser @TENRAP , @DIACHI ", new object[] { tenRap, diaChi });
        }
        #endregion

        #region updateTheater
        public void updateTheater(int maRap, String tenRap, String diaChi)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC TheaterListUpdate @MARAP , @TENRAP , @DIACHI ", new object[] { maRap, tenRap, diaChi });
        }
        #endregion

        #region deleteTheater
        public void deleteTheater(int maRap)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC TheaterListDelete @MARAP", new object[] { maRap });
        }
        #endregion


    }
}
