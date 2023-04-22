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
        public List<Product> GetProducts(Section section)
        {
            return productRepo.GetProducts(section.Id);
        }
        public List<Product> GetProducts(Section section, Department department)
        {
            return productRepo.GetProducts(section.Id, department.Id);
        }
        public void CreateProduct(Section section, Product product)
        {
            productRepo.CreateProduct(section.Id, product);
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
