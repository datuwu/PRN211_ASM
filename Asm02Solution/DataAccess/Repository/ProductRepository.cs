using BusinessObject;
using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddNew(Product product) => ProductDAO.Instance.AddNewProduct(product);

        public Product GetProductByID(int id) => ProductDAO.Instance.GetProductByID(id);

        public Product GetProductByName(string name) => ProductDAO.Instance.GetProductByName(name);

        public Product GetProductByPrice(decimal price) => ProductDAO.Instance.GetProductByPrice(price);

        public Product GetProductByUnitsInStock(int stock) => ProductDAO.Instance.GetProductByUnitsInStock(stock);

        public IEnumerable<Product> GetProductList() => ProductDAO.Instance.GetProductList();

        public void Remove(int id) => ProductDAO.Instance.RemoveProduct(id);

        public void Update(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
