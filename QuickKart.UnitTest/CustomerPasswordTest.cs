using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickKartBL;

namespace QuickKart.UnitTest
{
    [TestClass]
    public class CustomerPasswordTest
    { 
        [TestMethod]
        public void InvalidPassword_ShouldReturnNull()
        {
            Customer cs1 = new Customer(
                 101,
                      "John",
                      "Mysore",
                      8762542499,
                      "John@gmail.com",
                      "Regular",
                      new DateTime(2001, 07, 25),
                      Gender.Male,
                      "John@2365");

            Assert.AreEqual(null, cs1.Password);

        }
    }
}