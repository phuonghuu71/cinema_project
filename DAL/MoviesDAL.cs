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
            string query = "SELECT MAPHIM, TENPHIM, ANH, DAODIEN, THELOAI, KHOICHIEU, KETTHUC, THOILUONG, NGONNGU, Rated, NOIDUNG, DINHDANG " +
                "FROM PHIM";
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
        public bool insertMovie(String tenphim, String anh, String daodien, String theloai, String khoichieu, String ketthuc, String thoiluong, String ngonngu, String rated, String noidung, String dinhdang)
        {
            string query = string.Format("INSERT INTO PHIM(TENPHIM, ANH, DAODIEN, THELOAI, KHOICHIEU, KETTHUC, THOILUONG, NGONNGU, Rated, NOIDUNG, DINHDANG) SELECT N'{0}', BulkColumn, N'{1}', N'{2}', '{3}', '{4}', N'{5}', N'{6}', N'{7}', N'{8}', '{9}' from Openrowset(Bulk '{10}', Single_Blob) as Image", tenphim, daodien,theloai,khoichieu,ketthuc,thoiluong,ngonngu,rated,noidung, dinhdang, anh);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
        #region updateMovie
        public bool updateMovie(String tenphim, String daodien, String theloai, String khoichieu, String ketthuc, String thoiluong, String ngonngu, String rated, String noidung, String dinhdang, int maPhim)
        {
            string query = string.Format("UPDATE PHIM SET TENPHIM = N'{0}', DAODIEN = N'{1}', THELOAI = N'{2}', KHOICHIEU = N'{3}', KETTHUC = N'{4}', THOILUONG = N'{5}', NGONNGU = N'{6}', RATED = N'{7}', NOIDUNG = N'{8}', DINHDANG = N'{9}' WHERE MAPHIM = '{10}'", tenphim, daodien, theloai, khoichieu, ketthuc, thoiluong, ngonngu, rated, noidung, dinhdang, maPhim);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
        #region GetmovieIdByName
        public int getmovieIdByName(String movieName)
        {
            string query = string.Format("SELECT dbo.GetmovieIdByName( N'{0}' )", new object[] { movieName });
            object result = DataProvider.Instance.ExecuteScalar(query);
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

        #region deleteMovieByName
        public bool deleteMovieByName(string movieName)
        {
            string query = string.Format("DELETE FROM PHIM WHERE TENPHIM = N'{0}'", movieName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
    }
}
