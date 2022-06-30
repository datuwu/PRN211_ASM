using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public class OrderDetailDAO
{
    //Using Singleton Pattern
    private static OrderDetailDAO instance = null;
    private static readonly object instanceLock = new object();
    private OrderDetailDAO() { }
    public static OrderDetailDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }
    }
    //Get List of Order Detail
    public IEnumerable<OrderDetail> GetOrderDetailList()
    {
        List<OrderDetail> ordersDetailList;
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            ordersDetailList = fStoreContext.OrderDetails.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return ordersDetailList;
    }
    //Get specific OrderDetail by OrderID and ProductID
    public OrderDetail GetOrderDetailByID (int orderId, int productId)
    {
        OrderDetail item = null;
        try
        {
            using var fStoreContext = new FStoreContext();
            item = fStoreContext.OrderDetails.SingleOrDefault(o => o.ProductId == productId && o.OrderId == orderId);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return item;
    }
    //Get List of Order By MemberID
    public IEnumerable<OrderDetail> GetOrderDetailListByMemberID(int memId)
    {
        var ordersList = new List<Order>();
        var orderDetailList = new List<OrderDetail>();
        var list = new List<Order>();
        var final = new List<OrderDetail>();
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            ordersList = fStoreContext.Orders.ToList();
            orderDetailList = fStoreContext.OrderDetails.ToList();
            for (int i = 0; i < ordersList.Count(); i++)
            {
                if (ordersList[i].MemberId == memId)
                {
                    list.Add(ordersList[i]);
                }
            }
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = 0; i < orderDetailList.Count(); i++) 
                {
                    if (list[i].OrderId == orderDetailList[j].OrderId)
                    {
                        final.Add(orderDetailList[j]);
                    }
                }
                
            }

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return final;
    }

    public IEnumerable<OrderDetail> GetOrderDetailListByOrderID (int orderId)
    {
        var list = new List<OrderDetail>();
        var final = new List<OrderDetail>();
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            list = fStoreContext.OrderDetails.ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].OrderId == orderId)
                {
                    final.Add((OrderDetail)list[i]);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return final;
    }

    public IEnumerable<OrderDetail> GetOrderDetailListByListOrder (List<Order> id)
    {
        var list = new List<OrderDetail>();
        var final = new List<OrderDetail>();
        try
        {
            using var fStoreContext = new FStoreContext();
            list = fStoreContext.OrderDetails.ToList();
            for (int i = 0; i < id.Count(); i++)
            {
                for (int j = 0; j < list.Count(); j++)
                {
                    if (id[i].OrderId == list[j].OrderId)
                    {
                        final.Add(list[j]);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return final;
    }


    public double GetStatistic (DateTime a, DateTime b)
    {
        double total = 0;        
        var x = OrderDAO.Instance.Filter(a, b);
        var list = GetOrderDetailListByListOrder(x).ToList();
        try
        {   
            foreach(var item in list)
            {
                total = item.Quantity * (double)item.UnitPrice - (item.Quantity * (double)item.UnitPrice * (item.Discount/100));              
            }
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return total;
    }
    //Add new OrderDetail
    public void AddNew (OrderDetail orderDetail)
    {
        try
        {
            OrderDetail item = GetOrderDetailByID(orderDetail.OrderId, orderDetail.ProductId);
            if (item == null)
            {
                using var fStoreContext = new FStoreContext();
                fStoreContext.OrderDetails.Add(item);
                fStoreContext.SaveChanges();
            }
            else
            {
                throw new Exception("This OrderDetail has already exists.");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //Update OrderDetail
    public void Update(OrderDetail orderDetail)
    {
        try
        {
            OrderDetail item = GetOrderDetailByID(orderDetail.OrderId, orderDetail.ProductId);
            if (item != null)
            {
                using var fStoreContext = new FStoreContext();
                fStoreContext.OrderDetails.Update(item);
                fStoreContext.SaveChanges();
            }
            else
            {
                throw new Exception("This OrderDetail does not exist.");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //Remove OrderDetail
    public void Remove(int productId, int orderId)
    {
        try
        {
            OrderDetail item = GetOrderDetailByID(orderId, productId);
            if (item != null)
            {
                using var fStoreContext = new FStoreContext();
                fStoreContext.OrderDetails.Remove(item);
                fStoreContext.SaveChanges();
            }
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
