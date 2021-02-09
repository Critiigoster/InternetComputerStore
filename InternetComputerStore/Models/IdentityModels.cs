using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;
using InternetComputerStore.Models;
using System.Data.Entity;

namespace InternetComputerStore.Models
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
             var authenticationType = "Put authentication type Here";
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

            // Add custom user claims here
            return userIdentity;
        }
    }


}

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<Customer> Customers { get; set; }
    // Represents customers set in DataBase 

    public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema:false)
    {

    }

    public static ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }
}