using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Format
    {
        #region variable instance
        private int maDinhdang;
        private String tenDinhdang;
        #endregion

        #region getter_setter
        public int MaDinhdang { get => maDinhdang; set => maDinhdang = value; }
        public string TenDinhdang { get => tenDinhdang; set => tenDinhdang = value; }
        #endregion

        #region constructor
        public Format(int maDinhdang, String tenDinhdang)
        {
            this.maDinhdang = maDinhdang;
            this.tenDinhdang = tenDinhdang;
        }
        #endregion

        public Format(DataRow row)
        {
            this.maDinhdang = (int)row["MADINHDANG"];
            this.TenDinhdang = row["TENDINHDANG"].ToString();
        }
    }
}
