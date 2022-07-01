using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailByID(int orderId, int ProductId);
        IEnumerable<OrderDetail> GetOrderDetailsByMemberID(int memId);
        IEnumerable<OrderDetail> GetOrderDetailsByOrderID(int orderId);
        double GetStatistic(DateTime from, DateTime to);
        void AddNew(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Remove(int orderId, int productId);
    }
}
