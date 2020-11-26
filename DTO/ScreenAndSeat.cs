using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class ScreenAndSeat
    {
        #region variable instance
        int maPhongChieu;
        String tenPhongChieu;
        int soCot;
        int soHang;
        int maGhe;
        #endregion

        #region getter_setter
        public int MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public String TenPhongChieu { get => tenPhongChieu; set => tenPhongChieu = value; }
        public int SoCot { get => soCot; set => soCot = value; }
        public int SoHang { get => soHang; set => soHang = value; }
        public int MaGhe { get => maGhe; set => maGhe = value; }

        #endregion

        #region constructor
        public ScreenAndSeat(int maPhongChieu, string tenPhongChieu, int soCot, int soHang, int maGhe)
        {
            this.maPhongChieu = maPhongChieu;
            this.tenPhongChieu = tenPhongChieu;
            this.soCot = soCot;
            this.soHang = soHang;
            this.maGhe = maGhe;
        }
        #endregion

        public ScreenAndSeat(DataRow row)
        {
            this.MaPhongChieu = (int)row["MAPHONGCHIEU"];
            this.TenPhongChieu = row["TENPHONGCHIEU"].ToString();
            this.SoCot = (int)row["SOCOT"];
            this.soHang = (int)row["SOHANG"];
            this.MaGhe = (int)row["MAGHE"];
        }
    }
}
