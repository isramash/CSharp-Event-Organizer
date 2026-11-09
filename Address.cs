using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        // Private fields
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        // Properties
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        // Default constructor
        public Address()
        {
            street = string.Empty;
            city = string.Empty;
            zipCode = string.Empty;
            country = Countries.Sverige; // default value, can change
        }

        //Constructor  with parameters
        public Address(string street, string city, string zipCode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        // Validate method
        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(city);
                   
        }

        // ToString method
        public override string ToString()
        {
            return $"       {Street}    {ZipCode}    {City}    {Country}";
        }
    }
}
