using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bag Shot";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerid(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Somewhere",
                StreetLine2 = "Over the rainbow",
                City = "City",
                State = "State",
                Country = "Country",
                PostalCode = "0700"
            };
            addressList.Add(address);

            Address address2 = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Somewhere 2",
                StreetLine2 = "Over the rainbow 2",
                City = "City 2",
                State = "State 2",
                Country = "Country 2",
                PostalCode = "0700 2"
            };
            addressList.Add(address2);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
