using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class ProductService
    {
        private IProductRepo productRepo;
        public ProductService(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }

        public int GetLatestProductId()
        {
            return productRepo.GetLatestProductId();
        }
        public List<Product> GetProducts()
        {
            return productRepo.GetProducts();
        }
        public List<Product> GetProducts(Department department)
        {
            return productRepo.GetProducts(department.Id);
        }
        public void CreateProduct(Product product)
        {
            productRepo.CreateProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            productRepo.UpdateProduct(product);
        }
        public void DeleteProduct(Product product)
        {
            productRepo.DeleteProduct(product);
        }
    }
}
