using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class CustomerInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        public CustomerInfo(string firstname, string lastname, Address address, string phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Address = address;
            PhoneNumber = phonenumber;
        }
        public override string ToString()
        {
            return FirstName + ", " + LastName + ", " + Address + ", " + PhoneNumber;
        }
    }
}
