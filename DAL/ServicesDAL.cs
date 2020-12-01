using CSMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.DAL
{
    public class ServicesDAL
    {
        #region instance
        private static ServicesDAL instance;

        public static ServicesDAL Instance
        {
            get { if (instance == null) instance = new ServicesDAL(); return instance; }
            private set { instance = value; }
        }

        private ServicesDAL() { }
        #endregion

        #region getServicesList
        public List<Services> GetServiceList()
        {
            List<Services> serviceList = new List<Services>();
            string query = "SELECT * FROM DICHVU";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Services services = new Services(item);
                serviceList.Add(services);
            }
            return serviceList;
        }
        #endregion

        #region insertService
        public bool insertService(int serviceId, string serviceName, Decimal servicePrice)
        {
            string query = string.Format("INSERT INTO DICHVU(MADV, TENDV, GIADV) VALUES('{0}', N'{1}', '{2}')", serviceId, serviceName, servicePrice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region updateService
        public bool updateService(int serviceId, string serviceName, Decimal servicePrice)
        {
            string query = string.Format("UPDATE DICHVU SET TENDV = N'{0}', GIADV = '{1}' WHERE MADV = '{2}'", serviceName, servicePrice, serviceId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region deleteService
        public bool deleteService(int serviceId)
        {
            string query = string.Format("DELETE FROM DICHVU WHERE MADV = '{0}'", serviceId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region serviceExist
        public int ServiceExist(int ticketId, int serviceId)
        {
            string query = string.Format("select dbo.ServiceExist('{0}' , '{1}')", new object[] { ticketId, serviceId });
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }
        #endregion

        #region serviceCount
        public int ServiceCount(int ticketId, int serviceId)
        {
            string query = string.Format("select dbo.ServiceCount('{0}' , '{1}')", new object[] { ticketId, serviceId });
            object result = DataProvider.Instance.ExecuteScalar(query);
            if(result != null)
            {
                return (int)result;
            }
            return 0;
        }
        #endregion

        #region getServiceIdByName
        public int GetServiceIdByName(String serviceName)
        {
            string query = string.Format("SELECT MADV FROM DICHVU WHERE TENDV = N'{0}'", new object[] { serviceName });
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }
        #endregion

        #region getQuantityByTicketIdAndServiceId
        public int GetQuantityByTicketIdAndServiceId(int ticketId, int serviceId)
        {
            string query = string.Format("SELECT SOLUONG FROM ctDICHVU WHERE MAVE = '{0}' AND MADV = '{1}'", new object[] { ticketId, serviceId });
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }
        #endregion

        #region
        public bool DeleteDetailServiceByTicketd(int showtimeId)
        {
            string query = string.Format("DELETE FROM ctDICHVU WHERE MAVE = '{0}'",
                new object[] { showtimeId });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region
        public bool DeleteDetailServiceByTicketdServiceId(int showtimeId, int serviceId)
        {
            string query = string.Format("DELETE FROM ctDICHVU WHERE MAVE = '{0}' AND MADV = '{1}'",
                new object[] { showtimeId, serviceId });
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

    }

}


