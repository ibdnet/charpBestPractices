using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Product instantiated");
        }

        public Product(int productId, string productName, string description ) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

            Console.WriteLine("Product instance has the name {0} ", ProductName);
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + ") " + Description;
        }

    }

  
}
