using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class TicketDAL
    {
        #region instance
        private static TicketDAL instance;

        public static TicketDAL Instance
        {
            get { if (instance == null) instance = new TicketDAL(); return instance; }
            private set { instance = value; }
        }

        private TicketDAL() { }
        #endregion

        public List<Ticket> getTicketBySeatId(int seatId, String movieName, String timeBooking)
        {
            List<Ticket> ticketAt = new List<Ticket>();
            string query = string.Format("EXEC GetTicketBySeatId {0} , N'{1}' , '{2}'", seatId, movieName, timeBooking);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Ticket ticket = new Ticket(item);
                ticketAt.Add(ticket);
            }
            return ticketAt;
        }
        public int GetTicketIdByShowtimeIdAndSeatId(int showtimeId, int seatId)
        {
            string query = string.Format("SELECT MAVE FROM VE WHERE MALICHCHIEU = '{0}' AND MAGHE = '{1}'", showtimeId, seatId);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if(result != null)
            {
                return (int)result;
            }
            return 0;
        }

        public List<Ticket> GetTicketByTicketId(int ticketId)
        {
            List<Ticket> ticketAt = new List<Ticket>();
            string query = string.Format("EXEC GetTicketByTicketId '{0}'", ticketId);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Ticket ticket = new Ticket(item);
                ticketAt.Add(ticket);
            }
            return ticketAt;
        }

        public bool InsertService(int ticketId, int serviceId, int quantity) 
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC InsertService @MAVE , @MADV , @SOLUONG", new object[] { ticketId, serviceId, quantity });
            return result > 0;
        }
        public bool UpdateService(int ticketId, int serviceId, int quantity)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdateService @MAVE , @MADV , @SOLUONG", new object[] { ticketId, serviceId, quantity });
            return result > 0;
        }
        public bool UpdateTicketMoney(Decimal money, int ticketId)
        {
            string query = string.Format("UPDATE VE SET GIAVE = '{0}' WHERE MAVE = '{1}'", new object[] { money, ticketId });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTicketByTicketId(int ticketId, int seatId)
        {
            string query = string.Format("DELETE from ctDICHVU WHERE MAVE = '{0}' " +
                "DELETE FROM VE WHERE MAVE = '{1}' " +  
                "DELETE FROM ctLICHCHIEU WHERE MAGHE = '{2}'", new object[] { ticketId, ticketId, seatId });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public Decimal GetMoneyByTicketId(int ticketId)
        {
            string query = string.Format("SELECT GIAVE FROM VE WHERE MAVE = '{0}'", ticketId);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result != null)
            {
                return (Decimal)result;
            }
            return 0;
        }

    }
}
