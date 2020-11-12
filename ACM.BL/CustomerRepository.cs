using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve (int customerId)
        {
            Customer customer = new Customer(customerId);
            //Temporary hardcoded values to populate a customer
            if(customerId == 1)
            {
                customer.EmailAddress = "bilbo@swaggins.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Bagginz";
                customer.AddressList = addressRepository.RetrieveByCustomerid(customerId).ToList();
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
                    {
                        // Call an Insert Stored Procedure
                    }
                    else
                    {
                        //Call an Update Stored PRocedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
