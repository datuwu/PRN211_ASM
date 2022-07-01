using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrdersByMemberID(int memberID);
        Order GetOrderById(int orderID);
        void AddNew(Order order);
        void Update(Order order);
        void Remove(int orderID);
        IEnumerable<Order> Filter(DateTime from, DateTime to);
    }
}
