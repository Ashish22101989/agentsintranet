using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentIntranet.Model
{
    public abstract class Person
    {
        [Required]
        [StringLength(25, ErrorMessage = "First name cannot be longer than 25 characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(25, ErrorMessage = "Last name cannot be longer than 25 characters.")]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(25)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(15)]
        public string Zip { get; set; }


    }
}
