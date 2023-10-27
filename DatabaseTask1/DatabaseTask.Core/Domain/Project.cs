using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        public int UniqueProjectNr { get; set; }
        public IEnumerable<Specialist> Specialists { get; set; } = new List<Specialist>();
    }
}
