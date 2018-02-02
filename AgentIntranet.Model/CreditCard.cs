using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgentIntranet.Model
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string Number { get; set; }

        [Required]
        [StringLength(4)]
        public string Code { get; set; }

        public DateTime Valid { get; set; }

        [Required]
        [StringLength(25)]
        public string Type { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
