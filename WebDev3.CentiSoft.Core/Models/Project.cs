using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev3.CentiSoft.Core.Models
{
   // [DatabaseGenerated(DatabasedGenerated.Identity)]
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Task> Tasks { get; set; }

    }
}
