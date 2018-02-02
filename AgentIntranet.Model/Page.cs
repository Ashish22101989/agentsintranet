using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentIntranet.Model
{
    public class Page
    {
        public int PageId { get; set; }
        public string Title { get; set; }
        public string Data { get; set; }
        public string PostDate { get; set; }
        public string LastUpdated { get; set; }
        public bool Status { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
