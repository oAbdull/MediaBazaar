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

        public Product()
        {

        }

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
            set { this.productId = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
    }
}
