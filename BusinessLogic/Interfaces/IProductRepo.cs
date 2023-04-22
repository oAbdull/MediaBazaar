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
        List<Product> GetProducts(int sectionId);
        List<Product> GetProducts(int sectionId, int departmentId);
        void CreateProduct(int sectionId, Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
