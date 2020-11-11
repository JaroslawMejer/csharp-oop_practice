﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve (int customerId)
        {
            Customer customer = new Customer(customerId);
            //Temporary hardcoded values to populate a customer
            if(customerId == 1)
            {
                customer.EmailAddress = "bilbo@swaggins.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Bagginz";
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}