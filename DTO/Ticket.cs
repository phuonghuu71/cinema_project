using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Ticket
    {
        #region variable instance
        private String tenPhim;
        private String gioChieu;
        private int soCot;
        private int soHang;
        private String tenDv;
        private Decimal giaDv;
        private int soLuong;
        #endregion

        #region getter_setter
        public string TenPhim { get => tenPhim; set => tenPhim = value; }
        public string GioChieu { get => gioChieu; set => gioChieu = value; }
        public int SoCot { get => soCot; set => soCot = value; }
        public int SoHang { get => soHang; set => soHang = value; }
        public string TenDv { get => tenDv; set => tenDv = value; }
        public Decimal GiaDv { get => giaDv; set => giaDv = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        #endregion

        #region constructor
        public Ticket(string tenPhim, string gioChieu, int soCot, int soHang, string tenDv, Decimal giaDv, int soLuong)
        {
            this.tenPhim = tenPhim;
            this.gioChieu = gioChieu;
            this.soCot = soCot;
            this.soHang = soHang;
            this.tenDv = tenDv;
            this.giaDv = giaDv;
            this.soLuong = soLuong;
        }
        #endregion

        public Ticket(DataRow row)
        {
            this.tenPhim = row["TENPHIM"].ToString();
            this.gioChieu = row["GIOCHIEU"].ToString();
            this.soCot = Int32.Parse(row["SOCOT"].ToString());
            this.soHang = Int32.Parse(row["SOHANG"].ToString());
            this.tenDv = row["TENDV"].ToString();
            this.giaDv = Decimal.Parse(row["GIADV"].ToString());
            this.soLuong = Int32.Parse(row["SOLUONG"].ToString());
        }
    }
}
