using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class ScreenOnly
    {
        #region variable instance
        int maPhongChieu;
        String tenPhongChieu;
        String tenRap;
        #endregion

        #region getter_setter
        public int MaPhongChieu { get => maPhongChieu; set => maPhongChieu = value; }
        public String TenPhongChieu { get => tenPhongChieu; set => tenPhongChieu = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        #endregion

        #region constructor
        public ScreenOnly(int maPhongChieu, string tenPhongChieu, String tenRap)
        {
            this.maPhongChieu = maPhongChieu;
            this.tenPhongChieu = tenPhongChieu;
            this.tenRap = tenRap;
        }
        #endregion

        public ScreenOnly(DataRow row)
        {
            this.MaPhongChieu = (int)row["MAPHONGCHIEU"];
            this.TenPhongChieu = row["TENPHONGCHIEU"].ToString();
            this.TenRap = row["TENRAP"].ToString();
        }
    }
}
