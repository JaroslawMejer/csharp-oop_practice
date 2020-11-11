using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "bilbo@swaggins.com",
                FirstName = "Frodo",
                LastName = "Bagginz"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "bilbo@swaggins.com",
                FirstName = "Frodo",
                LastName = "Bagginz",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Somewhere",
                        StreetLine2 = "Over the rainbow",
                        City = "City",
                        State = "State",
                        Country = "Country",
                        PostalCode = "0700"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Somewhere 2",
                        StreetLine2 = "Over the rainbow 2",
                        City = "City 2",
                        State = "State 2",
                        Country = "Country 2",
                        PostalCode = "0700 2"
                    }
                }
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);

            }
        }
    }
}
