using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Statistical
    {
        #region variable instance
        private Decimal giaVe;
        private String tenRap;
        private String tenPhongchieu;
        private String ngayChieu;
        #endregion

        #region getter_setter
        public decimal GiaVe { get => giaVe; set => giaVe = value; }
        public string TenRap { get => tenRap; set => tenRap = value; }
        public string TenPhongchieu { get => tenPhongchieu; set => tenPhongchieu = value; }
        public string NgayChieu { get => ngayChieu; set => ngayChieu = value; }
        #endregion

        #region constructor
        public Statistical(decimal giaVe, string tenRap, string tenPhongchieu, string ngayChieu)
        {
            this.giaVe = giaVe;
            this.tenRap = tenRap;
            this.tenPhongchieu = tenPhongchieu;
            this.ngayChieu = ngayChieu;
        }
        #endregion

        public Statistical(DataRow row)
        {
            this.giaVe = Decimal.Parse(row["GIAVE"].ToString());
            this.tenRap = row["TENRAP"].ToString();
            this.tenPhongchieu = row["TENPHONGCHIEU"].ToString();
            this.ngayChieu = row["NGAYCHIEU"].ToString();
        }

        
    }
}
