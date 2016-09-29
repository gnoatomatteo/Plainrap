using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plainrap.Model
{
    public class Address
    {
        [PrimaryKey, AutoIncrement]
        private int ID { get; set; }
        private string street { get; set; }
        private string houseNumber { get; set; }
        private string city { get; set; }
        private string postalCode { get; set; }
        private string province { get; set; }

        public Address(string street, string houseNumber, string city, string postalCode, string province)
        {
            this.street = street;
            this.houseNumber = houseNumber;
            this.city = city;
            this.postalCode = postalCode;
            this.province = province;
        }
    }
}
