using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Services
    {
        #region variable instance
        private int maDV;
        private String tenDV;
        private Decimal giaDV;
        #endregion

        #region gettser_setter
        public int MaDV { get => maDV; set => maDV = value; }
        public string TenDV { get => tenDV; set => tenDV = value; }
        public Decimal GiaDV { get => giaDV; set => giaDV = value; }
        #endregion

        #region constructor
        public Services(int maDV, string tenDV, Decimal giaDV)
        {
            this.maDV = maDV;
            this.tenDV = tenDV;
            this.giaDV = giaDV;
        }
        #endregion

        public Services(DataRow row)
        {
            this.maDV = int.Parse(row["MADV"].ToString());
            this.tenDV = row["TENDV"].ToString();
            this.giaDV = Decimal.Parse(row["GIADV"].ToString());
        }

    }
}
