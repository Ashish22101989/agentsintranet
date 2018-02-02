using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentIntranet.Model
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }

        [Column("Customer Name")]
        public String FullName
        {
            set
            {
                value = FirstName + LastName;
            }
        }
        public DateTime CreateDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool Status { get; set; }

        //  public ICollection<Agent> Agents { get; set; }
        //  public ICollection<Page> Pages { get; set; }
        //  public ICollection<CreditCard> CreditCards { get; set; }
        //  public ICollection<Location> Locations { get; set; }


    }
}
