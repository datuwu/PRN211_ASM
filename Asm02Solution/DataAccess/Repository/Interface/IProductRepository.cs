using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductList();
        Product GetProductByID(int id);
        Product GetProductByName(string name);
        Product GetProductByPrice(decimal price);
        Product GetProductByUnitsInStock(int stock);
        void AddNew(Product product);
        void Update(Product product);
        void Remove(int id);
    }
}
