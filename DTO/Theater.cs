using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DTO
{
    public class Theater
    {
        #region variable instance
        private int mARAP;
        private String tENRAP;
        private String dIACHI;
        #endregion

        #region getter_setter
        public int MARAP { get => mARAP; set => mARAP = value; }
        public string TENRAP { get => tENRAP; set => tENRAP = value; }
        public string DIACHI { get => dIACHI; set => dIACHI = value; }
        #endregion

        #region constructor
        public Theater(int mARAP, string tENRAP, string dIACHI)
        {
            this.mARAP = mARAP;
            this.tENRAP = tENRAP;
            this.dIACHI = dIACHI;
        }
        #endregion

        public Theater(DataRow row)
        {
            this.MARAP = Int32.Parse(row["MARAP"].ToString());
            this.TENRAP = row["TENRAP"].ToString();
            this.DIACHI = row["DIACHI"].ToString();
        }
    }
}
