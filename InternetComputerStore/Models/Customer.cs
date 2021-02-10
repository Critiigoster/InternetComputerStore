using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InternetComputerStore.Models
{
    public class Customer
    {

        // IdentityUser 
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Name")]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Logins { get; set; }
        public string Claims { get; set; }

        [Display(Name = "Password")]
        public string PasswordHash { get; set; }
        public string Roles { get; set; }
        public int PhoneNumber { get; set; }
        public int SecurityStamp { get; set; }
        public int AccessFailedCount { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool PhoneNumberConfirmed { get; set; }

        






    }
}