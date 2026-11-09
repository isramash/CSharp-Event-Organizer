using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Participant
    {
        // Private fields
        private string firstName;
        private string lastName;
        private Address address;

        // Properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        // Constructor
        public Participant(string firstName, string lastName, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }

        // Validate method
        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(firstName)&&
                   !string.IsNullOrWhiteSpace(lastName);

        }
        // ToString method
        public override string ToString()
        {
            return $"{LastName},  {FirstName}        {Address}";
        }
    }
}
