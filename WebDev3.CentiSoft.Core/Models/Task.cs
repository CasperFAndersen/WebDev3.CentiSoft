using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev3.CentiSoft.Core.Models
{
    public class Task
    {
        public Task()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public float Duration { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
    }
}
