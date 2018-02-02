using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentIntranet.Model;

namespace AgentIntranet.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=AgentIntranet")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }

    }
}
