using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Showtime
    {
        #region variable instance
        private String tenPhim;
        private String tenRap;
        private String tenPhongChieu;
        private String ngayChieu;
        private String gioChieu;
        #endregion

        #region getter_setter
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string TenPhongChieu { get => tenPhongChieu; set => tenPhongChieu = value; }
        public string NgayChieu { get => ngayChieu; set => ngayChieu = value; }
        public string GioChieu { get => gioChieu; set => gioChieu = value; }
        #endregion

        #region constructor
        public Showtime(string tenPhim, string tenRap, string tenPhongChieu, string ngayChieu, string gioChieu)
        {
            this.tenPhim = tenPhim;
            this.tenRap = tenRap;
            this.tenPhongChieu = tenPhongChieu;
            this.ngayChieu = ngayChieu;
            this.gioChieu = gioChieu;
        }
        #endregion

        public Showtime(DataRow row)
        {
            this.TenPhim = row["TENPHIM"].ToString();
            this.TenRap = row["TENRAP"].ToString();
            this.TenPhongChieu = row["TENPHONGCHIEU"].ToString();
            this.NgayChieu = row["NGAYCHIEU"].ToString();
            this.GioChieu = row["GIOCHIEU"].ToString();
        }

    }
}
