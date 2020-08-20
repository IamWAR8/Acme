using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            var customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";
            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //Testing Static Methods
        public void StaticTest()
        {
            var c1= new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c1.FirstName = "Rosie";
            Customer.InstanceCount++;

            var c3 = new Customer();
            c1.FirstName = "Frodo";
            Customer.InstanceCount++;
           


            Assert.AreEqual(3, Customer.InstanceCount);


        }
    }
}
