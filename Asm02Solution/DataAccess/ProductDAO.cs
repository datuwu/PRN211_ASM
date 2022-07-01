using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess;

public class ProductDAO
{
    //Using Singleton Pattern
    private static ProductDAO instance = null;
    private static readonly object instanceLock = new object();
    private ProductDAO() { }
    public static ProductDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
    }

    //Get List of Member
    public List<Product> GetProductList()
    {
        List<Product> Products;
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            Products = fStoreContext.Products.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return Products;
    }
    //Get Product by ID
    public Product GetProductByID(int productId)
    {
        List<Product> products = GetProductList();
        Product p = products.SingleOrDefault(m => m.ProductId == productId);
        return p;
    }
    //Get Product by ProductName
    public Product GetProductByName(string name)
    {
        List<Product> products = GetProductList();
        Product p = products.SingleOrDefault(s => s.ProductName.Contains(name));
        return p;
    }
    //Get Product by UnitPrice
    public Product GetProductByPrice(decimal price)
    {
        List<Product> products = GetProductList();
        Product p = products.SingleOrDefault(s => s.UnitPrice == price);
        return p;
    }
    //Get Product by UnitsInStock
    public Product GetProductByUnitsInStock(int stock)
    {
        List<Product> products = GetProductList();
        Product p = products.SingleOrDefault(m => m.UnitsInStock == stock);
        return p;
    }
    //----------------------------------------------------------------
    //Add a new Product
    public void AddNewProduct(Product product)
    {
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            fStoreContext.Products.Add(product);
            fStoreContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //----------------------------------------------------------------
    //Update a new Member
    public void UpdateProduct(Product product)
    {
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            fStoreContext.Products.Update(product);
            fStoreContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    //----------------------------------------------------------------
    //Remove a member
    public void RemoveProduct(int productId)
    {
        try
        {
            using FStoreContext fStoreContext = new FStoreContext();
            var product = fStoreContext.Products.SingleOrDefault(m => m.ProductId == productId);
            fStoreContext.Products.Remove(product);
            fStoreContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
