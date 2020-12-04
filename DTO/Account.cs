using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Account
    {
        #region variable instance
        private String tenDangNhap;
        private String matKhau;
        private String loaiTK;
        private String hoTen;
        private String sdt;
        private String diaChi;
        private String cMND;
        private int tuoi;
        private String gioiTinh;
        #endregion

        #region getter_setter
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTK { get => loaiTK; set => loaiTK = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        #endregion

        #region constructor
        public Account(string tenDangNhap, string matKhau, string loaiTK, string hoTen, string sdt, string diaChi, string CMND, int tuoi, string gioiTinh)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.loaiTK = loaiTK;
            this.hoTen = hoTen;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.CMND = CMND;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
        }
    #endregion

    public Account(DataRow row)
        {
            this.TenDangNhap = row["TENDANGNHAP"].ToString();
            this.MatKhau = row["MATKHAU"].ToString();
            this.LoaiTK = row["LoaiTaiKhoan"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.Sdt = row["SoDienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.CMND = row["CMND"].ToString();
            this.Tuoi = int.Parse(row["Tuoi"].ToString());
            this.GioiTinh = row["GioiTinh"].ToString();
        }

        
    }
}
