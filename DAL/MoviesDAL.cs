using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class MoviesDAL
    {
        #region instance
        private static MoviesDAL instance;

        public static MoviesDAL Instance
        {
            get { if (instance == null) instance = new MoviesDAL(); return instance; }
            private set { instance = value; }
        }

        private MoviesDAL() { }
        #endregion

        #region getListMovies
        public List<Movies> getListMovies()
        {
            List<Movies> moviesList = new List<Movies>();
            string query = "SELECT MAPHIM, TENPHIM, ANH, DAODIEN, THELOAI, KHOICHIEU, KETTHUC, THOILUONG, NGONNGU, Rated, NOIDUNG, TENDINHDANG " +
                "FROM PHIM, DINHDANG " +
                "WHERE PHIM.MADINHDANG = DINHDANG.MADINHDANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Movies movies = new Movies(item);
                moviesList.Add(movies);
            }
            return moviesList;
        }
        #endregion

        #region insertMovie
        public bool insertMovie(String tenphim, String anh, String daodien, String theloai, String khoichieu, String ketthuc, String thoiluong, String ngonngu, String rated, String noidung, int madinhdang)
        {
            string query = string.Format("INSERT INTO PHIM(TENPHIM, ANH, DAODIEN, THELOAI, KHOICHIEU, KETTHUC, THOILUONG, NGONNGU, Rated, NOIDUNG, MADINHDANG) SELECT N'{0}', BulkColumn, N'{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}' from Openrowset(Bulk '{10}', Single_Blob) as Image", tenphim, daodien,theloai,khoichieu,ketthuc,thoiluong,ngonngu,rated,noidung,madinhdang,anh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
        #region getMovieByFormatID
        public Movies getMovieByFormatID(String tendinhdang)
        {
            string query = string.Format("SELECT * FROM DINHDANG, PHIM WHERE TENDINHDANG = '{0}'", tendinhdang);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Movies(item);
            }
            return null;
        }
        #endregion
        #region getFormat
        public List<Format> getFormat()
        {
            List<Format> format = new List<Format>();
            string query = "SELECT MADINHDANG, TENDINHDANG FROM DINHDANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Format formats = new Format(item);
                format.Add(formats);
            }
            return format;
        }
        #endregion
        #region GetmovieIdByName
        public int getmovieIdByName(String movieName)
        {
            object result = DataProvider.Instance.ExecuteScalar("SELECT dbo.GetmovieIdByName( @TENPHIM )", new object[] { movieName });
            return (int)result;
        }
        #endregion

        #region GetMovieByScreenId
        public List<Movies> GetMovieByScreenId(int screenId)
        {
            List<Movies> movieList = new List<Movies>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC GetMovieByScreenId @MAPHONGCHIEU ", new object[] { screenId });
            foreach (DataRow item in data.Rows)
            {
                Movies movies = new Movies(item);
                movieList.Add(movies);
            }
            return movieList;


        }
        #endregion
    }
}
