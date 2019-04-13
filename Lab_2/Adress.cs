using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Lab_2
{
    class Adress
    {
        public string Country;
        public string City;
        public string street;
        public string NumberOfHouse;
        public string apartment;
        public Adress()
        {

        }
        public Adress(string Coutnry, string city, string street, string NumberOfHouse, string apartment)
        {
            this.Country = Country;
            this.City = city;
            this.street = street;
            this.NumberOfHouse = NumberOfHouse;
            this.apartment = apartment;
        }
    }
}
