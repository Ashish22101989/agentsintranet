using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentIntranet.Model
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public ICollection<Agent> Agents { get; set; }
    }
}
