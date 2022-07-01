using BusinessObject;
using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddNew(OrderDetail orderDetail) => OrderDetailDAO.Instance.AddNew(orderDetail);

        public OrderDetail GetOrderDetailByID(int orderId, int ProductId) => OrderDetailDAO.Instance.GetOrderDetailByID(orderId, ProductId);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();

        public IEnumerable<OrderDetail> GetOrderDetailsByMemberID(int memId) => OrderDetailDAO.Instance.GetOrderDetailListByMemberID(memId);

        public IEnumerable<OrderDetail> GetOrderDetailsByOrderID(int orderId) => OrderDetailDAO.Instance.GetOrderDetailListByOrderID(orderId);
        public double GetStatistic(DateTime from, DateTime to) => OrderDetailDAO.Instance.GetStatistic(from, to);

        public void Remove(int orderId, int productId) => OrderDetailDAO.Instance.Remove(orderId, productId);

        public void Update(OrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
        
    }
}
