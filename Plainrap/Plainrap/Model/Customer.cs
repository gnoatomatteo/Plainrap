using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plainrap.Model
{
    public class Customer
    {
        private string name { get; }
        private Address address { get; }
        [PrimaryKey]
        private string custmerCode { get; }

        public Customer(string name, Address address, string customerCode)
        {
            this.name = name;
            this.address = address;
            this.custmerCode = custmerCode;
        }

        public Customer() { }
    }
}
