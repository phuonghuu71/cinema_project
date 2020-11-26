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
        private Decimal ticketPrice;
        #endregion

        #region getter_setter
        public decimal TicketPrice { get => ticketPrice; set => ticketPrice = value; }
        #endregion

        #region constructor
        public Statistical(decimal ticketPrice)
        {
            this.ticketPrice = ticketPrice;
        }
        #endregion

        public Statistical(DataRow row)
        {
            this.ticketPrice = Decimal.Parse(row["GIAVE"].ToString());
        }
    }
}
