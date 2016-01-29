﻿using System;
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
        public const double InchesPerMeter = 39.37;

        #region Contructor
        public Product()
        {
            Console.WriteLine("Product instantiated");
           // this.ProductVendor = new Vendor();
        }

        public Product(int productId, string productName, string description ) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
            
            Console.WriteLine("Product instance has the name {0} ", ProductName);
        }
        #endregion  

        #region Properties

        private DateTime? availabilityDate;

        public DateTime? AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
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
        private Vendor productVendor;

        public Vendor ProductVendor
        {
            get {
                if (productVendor == null)
                    productVendor = new Vendor();

                return productVendor;
            }
            set { productVendor = value; }
        }

        #endregion

        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + ") " + Description +
                " Available on: " +
                AvailabilityDate?.ToShortDateString();
        }

    }

  
}
