using BusinessObject;
using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddNew(Order order) => OrderDAO.Instance.AddNewOrder(order);

        public IEnumerable<Order> Filter(DateTime from, DateTime to) => OrderDAO.Instance.Filter(from, to);

        public Order GetOrderById(int orderID) => OrderDAO.Instance.GetOrderByID(orderID);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();


        public IEnumerable<Order> GetOrdersByMemberID(int memberID) => OrderDAO.Instance.GetOrderListByMemberID(memberID);

        public void Remove(int orderID) => OrderDAO.Instance.RemoveOrder(orderID);

        public void Update(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
