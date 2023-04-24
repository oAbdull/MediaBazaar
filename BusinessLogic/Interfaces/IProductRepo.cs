using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductRepo
    {
        int GetLatestProductId();
        List<Product> GetProducts();
        List<Product> GetProducts(int departmentId);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);

        void AddToDepartment(int departmentId, Product product);
        void RemoveFromDepartment(Product product);
    }
}
