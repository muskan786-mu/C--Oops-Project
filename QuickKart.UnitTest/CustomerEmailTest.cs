using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickKartBL;

namespace QuickKart.UnitTest
{ 
    [TestClass]
    public class CustomerEmailTest
    {
        [TestMethod]
        public void InvalidEmail_ShouldReturnNull()
        {
            Customer customer = new Customer(
                101,
                "John",
                "Mysore",
                8762542499,
                "John.com",
                "Regular",
                new DateTime(2001, 07, 25),
                Gender.Male,
                "John@2365");
            Assert.AreEqual(null, customer.EmailId);
        }
    }
}
