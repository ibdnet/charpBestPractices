﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()

        {
            //arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.ProductId = 1;
            currentProduct.Description = "15-inch steel blade hand saw";
            var expected = "Hello Saw (1) 15-inch steel blade hand saw";

            //act
            var actual = currentProduct.SayHello();
           // Console.WriteLine(actual);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHelloParmTest()

        {
            //arrange
            var currentProduct = new Product(1, "Saw", "15-inch steel blade hand saw");
            
            var expected = "Hello Saw (1) 15-inch steel blade hand saw";

            //act
            var actual = currentProduct.SayHello();

      
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}