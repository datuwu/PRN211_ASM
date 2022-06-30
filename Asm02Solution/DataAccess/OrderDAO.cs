using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;
public class OrderDAO
{
    //Using Singleton Pattern
    private static OrderDAO instance = null;
    private static readonly object instanceLock = new object();
    private OrderDAO() { }
    public static OrderDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
    }
    //Get List of Order
    public IEnumerable<Order> GetOrderList()
    {
        List<Order> ordersList;
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            ordersList = fStoreContext.Orders.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return ordersList;
    }

    //Get List of Order By MemberID
    public IEnumerable<Order> GetOrderListByMemberID(int memId)
    {
        var ordersList = new List<Order>();
        var list = new List<Order>();
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            ordersList = fStoreContext.Orders.ToList();
            for (int i = 0; i <ordersList.Count(); i++)
            {
                if (ordersList[i].MemberId == memId)
                {
                    list.Add(ordersList[i]);
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }
    //----------------------------------------------------------------
    //Get Order by ID
    public Order GetOrderByID(int orderId)
    {
        Order order = null;
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            order = fStoreContext.Orders.SingleOrDefault(o => o.OrderId == orderId);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return order;
    }
    //----------------------------------------------------------------
    //Add a new Order
    public void AddNewOrder(Order order)
    {
        try
        {
            Order item = GetOrderByID(order.OrderId);
            if (item == null)
            {
                using FStoreContext fStoreContext = new FStoreContext();
                fStoreContext.Orders.Add(order);
                fStoreContext.SaveChanges();
            }
            else
            {
                throw new Exception("This order had already exist!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //----------------------------------------------------------------
    //Update a new Order
    public void UpdateOrder(Order order)
    {
        try
        {
            Order item = GetOrderByID(order.OrderId);
            if (item != null)
            {
                using FStoreContext fStoreContext = new FStoreContext();
                fStoreContext.Orders.Update(order);
                fStoreContext.SaveChanges();
            }
            else
            {
                throw new Exception("This order is not exist!");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //----------------------------------------------------------------
    //Remove a member
    public void RemoveOrder(int orderId)
    {
        try
        {
            Order item = GetOrderByID(orderId);
            if (item != null)
            {
                using FStoreContext fStoreContext = new FStoreContext();
                fStoreContext.Orders.Remove(item);
                fStoreContext.SaveChanges();
            }
            else
            {
                throw new Exception("This order is not exist");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //----------------------------------------------------------------
    //Filter

    public List<Order> Filter(DateTime a, DateTime b)
    {
        var ordersList = new List<Order>();
        var list = new List<Order>();
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            ordersList = fStoreContext.Orders.ToList();
            for (int i = 0; i < ordersList.Count(); i++)
            {
                if (ordersList[i].OrderDate >= a && ordersList[i].OrderDate <= b)
                {
                    list.Add(ordersList[i]);
                }
            }
            list = list.OrderByDescending(x => x.OrderDate).ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return list;
    }




}
