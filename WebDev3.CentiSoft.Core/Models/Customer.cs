using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev3.CentiSoft.Core.Models
{
    public class Customer
    {
        public Customer()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address1 { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ClientId { get; set; }
        public List<Project> Projects { get; set; }

    }
}
