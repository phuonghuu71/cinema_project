using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Movies
    {
        #region variable instance
        private int maPhim;
        private String tenPhim;
        private Image aNh;
        private String daoDien;
        private String theLoai;
        private DateTime khoiChieu;
        private DateTime ketThuc;
        private String thoiLuong;
        private String ngonNgu;
        private String raTed;
        private String noiDung;
        private String dinhDang;
        #endregion

        #region getter_setter
        public int MaPhim { get => maPhim; set => maPhim = value; }
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public Image ANh { get => aNh; set => aNh = value; }
        public string DaoDien { get => daoDien; set => daoDien = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public DateTime KhoiChieu { get => khoiChieu; set => khoiChieu = value; }
        public DateTime KetThuc { get => ketThuc; set => ketThuc = value; }
        public string ThoiLuong { get => thoiLuong; set => thoiLuong = value; }
        public string NgonNgu { get => ngonNgu; set => ngonNgu = value; }
        public string RaTed { get => raTed; set => raTed = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string DinhDang { get => dinhDang; set => dinhDang = value; }
        #endregion

        #region constructor
        public Movies(int maPhim, string tenPhim, Image aNh, string daoDien, string theLoai, DateTime khoiChieu, DateTime ketThuc, string thoiLuong, string ngonNgu, string raTed, string noiDung, string dinhDang)
        {
            this.maPhim = maPhim;
            this.tenPhim = tenPhim;
            this.aNh = aNh;
            this.daoDien = daoDien;
            this.theLoai = theLoai;
            this.khoiChieu = khoiChieu;
            this.ketThuc = ketThuc;
            this.thoiLuong = thoiLuong;
            this.ngonNgu = ngonNgu;
            this.raTed = raTed;
            this.noiDung = noiDung;
            this.dinhDang = dinhDang;
        }
        #endregion

        public Movies(DataRow row)
        {
            this.MaPhim = (int)row["MAPHIM"];
            this.TenPhim = row["TENPHIM"].ToString();
            byte[] data = (byte[])row["ANH"];
            MemoryStream ms = new MemoryStream(data);
            this.ANh = Image.FromStream(ms);
            this.DaoDien = row["DAODIEN"].ToString();
            this.TheLoai = row["THELOAI"].ToString();
            this.KhoiChieu = (DateTime)row["KHOICHIEU"];
            this.KetThuc = (DateTime)row["KETTHUC"];
            this.ThoiLuong = row["THOILUONG"].ToString();
            this.NgonNgu = row["NGONNGU"].ToString();
            this.RaTed = row["Rated"].ToString();
            this.NoiDung = row["NOIDUNG"].ToString();
            this.DinhDang = row["DINHDANG"].ToString(); 
        }
    }
}
