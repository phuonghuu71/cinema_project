using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class ShowtimeDAL
    {
        #region instance
        private static ShowtimeDAL instance;

        public static ShowtimeDAL Instance
        {
            get { if (instance == null) instance = new ShowtimeDAL(); return instance; }
            private set { instance = value; }
        }

        private ShowtimeDAL() { }
        #endregion

        #region getShowtimeList
        public List<Showtime> getShowtimeList()
        {
            List<Showtime> showtimeList = new List<Showtime>();
            string query = "EXEC GetShowtimeList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Showtime showtimes = new Showtime(item);
                showtimeList.Add(showtimes);
            }
            return showtimeList;
        }
        #endregion

        #region GetscreenIdByTheaterNameAndScreenName
        public int getscreenIdByTheaterNameAndScreenName(String theaterName, String screenName)
        {
            string query = string.Format("SELECT dbo.GetscreenIdByTheaterNameAndScreenName( N'{0}' , N'{1}' )", new object[] { theaterName, screenName });
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }
        #endregion

        #region GettheaterIdByName
        public int gettheaterIdByName(String theaterName)
        {
            object result = DataProvider.Instance.ExecuteScalar("SELECT dbo.GettheaterIdByName( @TENRAP )", new object[] { theaterName });
            return (int)result;
        }
        #endregion

        #region InsertShowtime
        public bool insertShowtime(String day, String hour, int movieId, int screenId)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC InsertShowtime @NGAYCHIEU , @GIOCHIEU , @MAPHIM , @MAPHONGCHIEU ", new object[] { day, hour, movieId, screenId });
            return result > 0;
        }
        #endregion

        #region EditShowtime
        public bool editShowtime(String day, String hour, int movieId, int screenId, int showtimeId)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC EditShowtime @NGAYCHIEU , @GIOCHIEU , @MAPHIM , @MAPHONGCHIEU , @MALICHCHIEU", new object[] { day, hour, movieId, screenId, showtimeId });
            return result > 0;
        }
        #endregion

        #region GetShowtimeByTheaterNameScreenNameMovieName
        public List<Showtime>getShowtimeByTheaterNameScreenNameMovieName(String theaterName, String screenName, String movieName)
        {
            List<Showtime> showtimeList = new List<Showtime>();
            string query = string.Format("EXEC GetShowtimeByTheaterNameScreenNameMovieName N'{0}' , N'{1}' , N'{2}'", new object[] { theaterName, screenName, movieName });
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Showtime showtimes = new Showtime(item);
                showtimeList.Add(showtimes);
            }
            return showtimeList;
        }
        #endregion

        #region GetShowtimeIdByMovieNameAndTimeBookingAndScreenNameAndTheaterName
        public int getShowtimeIdByMovieNameAndTimeBookingAndScreenNameAndTheaterName(String movieName, String timeBooking, String screenName, String theaterName)
        {
            object result = DataProvider.Instance.ExecuteScalar("EXEC GetShowtimeIdByMovieNameAndTimeBookingAndScreenNameAndTheaterName @TENPHIM , @GIOCHIEU , @TENPHONGCHIEU , @TENRAP", new object[] { movieName, timeBooking, screenName, theaterName });
            if(result != null)
            {
                return (int)result;
            }
            return 0;
        }
        #endregion

        #region
        public bool DeleteDetailShowtimeByShowtimeId(int showtimeId)
        {
            string query = string.Format("DELETE FROM ctLICHCHIEU WHERE MALICHCHIEU = '{0}'",
                new object[] { showtimeId });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region
        public bool DeleteShowtimeByShowtimeId(int showtimeId)
        {
            string query = string.Format("DELETE FROM LICHCHIEU WHERE MALICHCHIEU = '{0}'",
                new object[] { showtimeId });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
    }
}
