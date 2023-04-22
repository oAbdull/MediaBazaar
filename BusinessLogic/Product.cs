using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Product
    {
        private int productId;
        private string name;
        private int price;
        private int quantity;
        private int departmentId;

        public Product(int id, string name, int price, int quantity)
        {
            this.productId = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public int Id
        {
            get { return this.productId; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int Price
        {
            get { return this.price; }
        }
        public int Quantity
        {
            get { return this.quantity; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
    }
}
