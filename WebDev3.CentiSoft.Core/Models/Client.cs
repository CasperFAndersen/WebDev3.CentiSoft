using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev3.CentiSoft.Core.Models
{
    public class Client
    {
        public Client()
        {

        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
