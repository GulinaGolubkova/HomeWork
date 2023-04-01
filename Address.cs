using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        
        public Address(string city, string street, int housenumber, int flatnumber)
        {
            City = city;
            Street = street;    
            HouseNumber = housenumber;
            FlatNumber = flatnumber;
        }
        public override string ToString()
        {
            return "Address:" + City + ", " + Street + ", " + HouseNumber + ", " + FlatNumber;
        }
    }
}
