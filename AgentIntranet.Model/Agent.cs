using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AgentIntranet.Model
{
    public class Agent : Person
    {
        public int AgentId { get; set; }

        [StringLength(255)]
        public string ImageURL { get; set; }

        [StringLength(20)]
        public string Position { get; set; }

        public bool Status { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
